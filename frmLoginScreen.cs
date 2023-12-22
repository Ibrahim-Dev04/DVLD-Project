using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_Project
{
    public partial class frmLoginScreen : Form
    {
        private bool  dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        
        clsUser _User;
        string  _FolderPath = @"C:\UserInfo";
        string  _FileName = @"UserNameAndPassword.txt";
        string  _Filepath;
        char    _Separator = ',';

        string _UserName;
        string _Password;
        public frmLoginScreen()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Optional
            this.MouseDown += frmLoginScreen_MouseDown;
            this.MouseMove += frmLoginScreen_MouseMove;
            this.MouseUp += frmLoginScreen_MouseUp;
        }

        string[] SplitString(string Record)
        {
            return Record.Split(_Separator);
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string FileRecord = File.ReadLines(_GetFilePath()).FirstOrDefault();

            if (FileRecord != null)
            {
                string[] UserNameAndpassword = SplitString(FileRecord);
                TbUserName.Text = UserNameAndpassword[0];
                TbPassword.Text = UserNameAndpassword[1];
            }
            this.CenterToScreen();
        }

        private void frmLoginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmLoginScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newPoint = dragFormPoint;
                newPoint.X += Cursor.Position.X - dragCursorPoint.X;
                newPoint.Y += Cursor.Position.Y - dragCursorPoint.Y;
                this.Location = newPoint;
            }
        }

        private void frmLoginScreen_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (CbRememberMe.Checked && _isUserExist())
            {
                _SaveUserLoginInfoToTxtFile();
            }
            else
            {
                _RemoveRecordFromFile();
                TbUserName.Text = "";
                TbPassword.Text = "";
            }

            this.Close();
        }

        string _PrepareUserNameAndPasswordLoginRecord()
        {
            string userName = TbUserName.Text.ToString();
            string password = TbPassword.Text.ToString();
            
            return userName + _Separator + password;
        }

        string _GetFilePath()
        {
            return Path.Combine(_FolderPath, _FileName);
        }

        void _SaveUserLoginInfoToTxtFile()// if loginStatus =1 --> remember me ,0 don't remember
        {

            _Filepath = Path.Combine(_FolderPath, _FileName);

            Directory.CreateDirectory(_FolderPath);

            try
            {
                if (Directory.Exists(_FolderPath))
                {
                    string UserLoginRecordInfo = _PrepareUserNameAndPasswordLoginRecord();

                    File.WriteAllText(_Filepath, UserLoginRecordInfo);
                }
            }
            catch (Exception ex)
            {

            }

        }

        void _RemoveRecordFromFile()
        {
            _Filepath = _GetFilePath();
            try
            {
                if (Directory.Exists(_FolderPath))
                {
                    File.WriteAllText(_Filepath, "");
                }
            }
            catch (Exception ex)
            {

            }
        }

        bool _isUserExist()
        {
            if (clsUser.isExist(_UserName, _Password))
            {
                _User = clsUser.FindByUserName(_UserName);
                return true;
            }
            return false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            _UserName = TbUserName.Text.ToString();
            _Password = TbPassword.Text.ToString();
            _User = clsUser.FindByUserName(_UserName);

            if (_User == null)
            {
                MessageBox.Show($"User with UserName = {_UserName} Does not Exist.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!_isUserExist())
            {
                MessageBox.Show("Invalid UserName or password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (!_User.isActive)
            {
                MessageBox.Show("User is not active! please contact the administrator", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CbRememberMe.Checked && _isUserExist())
            {
                _SaveUserLoginInfoToTxtFile();
                 GlobalSettings._GlobalUserObj = _User ;
            }
            else
            {
                _RemoveRecordFromFile();
                TbUserName.Text = "";
                TbPassword.Text = "";
            }

            Mainfrm frm = new Mainfrm();
            frm.ShowDialog();
        }
    } 
}
