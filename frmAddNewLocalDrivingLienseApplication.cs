using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBusinessAccessLayer;
using ApplicationTypesBusinessLayer;
using UserBusinessLayer;
using LocalDrivngLicenseApplicationBusinessLayer;
using System.Deployment.Internal;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DVLD_Project
{
    public partial class frmAddNewLocalDrivingLienseApplication : Form
    {
        clsApplicationType _ApplicationType;
        clsApplication _ApplicationObj;
        LocalDrivingLicApp _LDAppobj;

        int _PersonID = 0;


        public frmAddNewLocalDrivingLienseApplication(int AppTypeID)
        {
            InitializeComponent();

            _ApplicationType = clsApplicationType.FindByID(AppTypeID);
        }

        private void btnClosefrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TcAddNewLocalDrivingLicenseApp.SelectedIndex < TcAddNewLocalDrivingLicenseApp.TabCount - 1)
            {
                TcAddNewLocalDrivingLicenseApp.SelectedIndex++;
            }
        }//asasdfasfasdfasd asdf asasdas

        private void frmAddNewLocalDrivingLienseApplication_Load(object sender, EventArgs e)
        {
            _LoadDataToForm();
        }

        void _LoadLicenseClassesToCb()
        {
            DataTable dt = new DataTable();
            dt = clsApplication.GetLicenceClasses();

            foreach (DataRow Row in dt.Rows)
            {
                CbLicenseClasses.Items.Add(Row["ClassName"]);
            }

            CbLicenseClasses.SelectedIndex = 0;
        }

        void _LoadDataToForm()
        {
            _LoadLicenseClassesToCb();
            lblApplicationDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
            lblAppFees.Text = _ApplicationType.AppFees.ToString();
            lblUserCreatedBy.Text = GlobalSettings._GlobalUserObj.UserName;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool _isPersonHasOrNewIn_A_LdApp()
        {
            string ClassName = CbLicenseClasses.SelectedItem.ToString();
            int PersonID = _PersonID;

            return (LocalDrivingLicApp.CheckIsLDApplicationCompletedByClassNameAndPersonID(ClassName, PersonID)
                  ||
                    LocalDrivingLicApp.CheckIsLdApplicationIsNewByClassNameAndPersonID(ClassName, PersonID)
                    );
        }

        bool _FillLocalDrivingLicenseAppObj_Save(int classID,int ApplicationID)
        {
            _LDAppobj = new LocalDrivingLicApp();

            _LDAppobj.ApplicationID = ApplicationID;
            _LDAppobj.LicenseClassID = classID;

            return (_LDAppobj.Save());
        }

        void _FillApplicationObjAndSave()
        {
            _ApplicationObj = new clsApplication();

            _ApplicationObj.applicationpersonid = _PersonID;
            _ApplicationObj.applicationdate = DateTime.Now;
            _ApplicationObj.applicationtypeid = _ApplicationType.ID;
            _ApplicationObj.applicationstatus = 1;
            _ApplicationObj.laststatusdate = DateTime.Now;
            _ApplicationObj.paidfees = 15;
            _ApplicationObj.createdbyuserid = GlobalSettings._GlobalUserObj.ID;

            string ClassName = CbLicenseClasses.SelectedItem.ToString();
            int ClassId = clsApplication.GetLicenseClassIDbyClassName(ClassName);

            if (_ApplicationObj.Save())
            {
                if (_FillLocalDrivingLicenseAppObj_Save(ClassId,_ApplicationObj.applicationid))
                {
                    MessageBox.Show("Saved", "Data saved Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saved", "Data saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // here we should get the license class id using className to save application reference to l.d.a

            }
            else
            {
                MessageBox.Show("Saved", "Data saved Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("Some info are missed,Make sure that all info is set", "Missed info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_isPersonHasOrNewIn_A_LdApp())
            {
                string ClassName = CbLicenseClasses.SelectedItem.ToString();
                _ApplicationObj = clsApplication.FindByPersonIDAndClassName(_PersonID,ClassName);
                 
                if(_ApplicationObj != null)
                _LDAppobj = LocalDrivingLicApp.FindByApplicationID(_ApplicationObj.applicationid);

                if (_LDAppobj != null)
                {
                    MessageBox.Show($"Choose another class,the selected person Already have an active application for the selected class with Id =" +
                                     $" {_LDAppobj.LocalDrivingLicenseApplicationID};", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                _FillApplicationObjAndSave();
            }
        }

        private void ctlrPersonCardWithFilter1_OnPersonSelected(int obj)
        {
            _PersonID = obj;
        }
    }
}
