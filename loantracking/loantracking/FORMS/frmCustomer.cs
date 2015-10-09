using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using loantracking.CLASSES;


namespace loantracking.FORMS
{
    public partial class frmCustomer : Form
    {
     
        public ListView lsvevent = new ListView();
        public Int32 mlt;
        string pictureBarrowerImages = "";
        string InsertPictureBarrowerImages = "";
        string namePictures = "";
        public frmCustomer()
        {
            InitializeComponent();
        }

 
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            if (PUBLIC_VARS.EDITMODE == true)
            {
                cl_moneylender cm = new cl_moneylender();
                cl_LenderInformation c_info = new cl_LenderInformation();
                cm.LOADTOFIELDS(mlt);
                txtAddress.Text = cm.propAddress;
                txtFname.Text = cm.propfname;
                txtLname.Text = cm.proplname;
                txtMI.Text = cm.propMI;
                txtAge.Text = cm.propAge.ToString();
                txtTin_no.Text = cm.propCreditLimit.ToString();
                txtContactNo.Text = cm.propContact_no;
                txtMoneyLenderID.Text = cm.propLenderID;

                c_info.LOAD_TOFIELDSinfo(mlt);
                txtbirthplace.Text = c_info.propbirthplace;
                dob.Value = c_info.propDOB;
                cboCivilStatus.Text = c_info.propCivilStatus;
                cboGender.Text = c_info.propGender;
                cbohousetype.Text = c_info.propHouseType;
                txtemail.Text = c_info.propEmail;
                txtoccupation.Text = c_info.propOccupation;
                txtposition.Text = c_info.propPosition;
                txtlengthservice.Text = Convert.ToInt32(c_info.propLengthofService).ToString();
                txtcompanyaddress.Text = c_info.propCompanyAdd;
                txtcompanyname.Text = c_info.propCompanyName;

                cm.loadPictureBarrower(mlt);
                //pictureBarrowerImages = cm.propPicBarrower;
                picBorrower.Image = Image.FromFile(@"D:\MY PROJECTS\LoanTrackingSystem\loantracking\loantracking\bimages\" + cm.propPicBarrower);
                picBorrower.SizeMode = PictureBoxSizeMode.StretchImage;

               // picBorrower.Image = Image.FromFile(@"D:\MY PROJECTS\LoanTrackingSystem\loantracking\loantracking\bimages\default_avatar.jpg");
               // picBorrower.SizeMode = PictureBoxSizeMode.StretchImage;


                if (c_info.propCivilStatus != "Single")
                {
                    cl_spouse sp = new cl_spouse();
                    sp.LOAD_TOFIELDSPOUSE(mlt);
                    txtspousename.Text = sp.propspousename;
                    txtSpouseAge.Text = Convert.ToInt32(sp.props_age).ToString();
                    txtspouseP.Text = sp.propsPosition;
                    txtsCompany.Text = sp.propsCompany;
                    txtSoCCu.Text = sp.propspouseOcc;
                }


            }
            else
            { 

                MYFUNCTIONS f = new MYFUNCTIONS();
                DateTime dt = DateTime.Today;
                Int64 dx =f.autoUserID()+1;
                txtMoneyLenderID.Text =dt.Year.ToString("X2") + String.Format("{0:D5}", dx);
               picBorrower.Image = Image.FromFile(@"D:\MY PROJECTS\LoanTrackingSystem\loantracking\loantracking\bimages\default_avatar.jpg");
               picBorrower.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            
            if(txtAge.Text == "" || txtContactNo.Text == "" || txtFname.Text == "" || txtLname.Text =="" || txtAddress.Text == "" || txtContactNo.Text == ""){
                MessageBox.Show("Please supply the required fields.");
                return;
            }
            if(txtlengthservice.Text == ""){
                txtlengthservice.Text = "0";
            }
            cl_moneylender cMoneyLender = new cl_moneylender();
            cl_LenderInformation l_Info = new cl_LenderInformation();
            cMoneyLender.propfname = txtFname.Text;
            cMoneyLender.proplname = txtLname.Text;
            cMoneyLender.propMI = txtMI.Text;
            cMoneyLender.propAddress = txtAddress.Text;
            cMoneyLender.propAge = Convert.ToInt32(txtAge.Text);
            cMoneyLender.propCreditLimit = Convert.ToDouble(222);
            cMoneyLender.propLenderID = txtMoneyLenderID.Text;
            cMoneyLender.propContact_no = txtContactNo.Text;

            l_Info.propLengthofService = Convert.ToInt32(txtlengthservice.Text.ToString());
            l_Info.propHouseType = cbohousetype.Text;
            l_Info.propGender = cboGender.Text;
            l_Info.propEmail = txtemail.Text;
            l_Info.propOccupation  = txtoccupation.Text;
            l_Info.propPosition = txtposition.Text;
            l_Info.propTIN_no = txtTin_no.Text;
            l_Info.propCompanyName = txtcompanyname.Text;
            l_Info.propCompanyAdd = txtcompanyaddress.Text;
            l_Info.propCivilStatus = cboCivilStatus.Text;
            l_Info.propbirthplace = txtbirthplace.Text;
            l_Info.propDOB = dob.Value;

            cl_spouse sp = new cl_spouse();

            sp.propspousename  = txtspousename.Text;  
            sp.propspouseOcc = txtSoCCu.Text;
            sp.propsCompany =txtsCompany.Text;
            sp.propsPosition=txtspouseP.Text;
            if (cboCivilStatus.Text != "Single")
            {
               sp.props_age = Convert.ToInt32(txtSpouseAge.Text);
            }
            if (cMoneyLender.propAge < 18 )
            {
                MessageBox.Show("Age should not lesser than 18");
                return;
            }
            if (PUBLIC_VARS.EDITMODE == true){
                
                cMoneyLender.UPDATE_DATA(mlt);

                int l_sid = Convert.ToInt32(PUBLIC_VARS.d.getlastid().ToString());
                l_Info.propmonenylenderInfoID = l_sid;
                l_Info.INSERT_DATATOLENDER();
                if (cboCivilStatus.Text != "Single")
                {
                    sp.propMoneyLender_id = l_sid;
                    sp.UPDATE_SPOUSE(mlt);

                }
                cMoneyLender.propMoneyLender_id = mlt;
                cMoneyLender.propPicBarrower = InsertPictureBarrowerImages;
                cMoneyLender.UpdatePicBarrower();
                MessageBox.Show( PUBLIC_VARS.updateData);
            }
            else{
                MYFUNCTIONS f = new MYFUNCTIONS();

                if (cMoneyLender.isBarrowerExist() == true) {
                    MessageBox.Show("Record already exist.");
                    return;
                }


                cMoneyLender.INSERT_DATA();
                int iiiD = PUBLIC_VARS.d.getlastid();
                int l_sid = Convert.ToInt32(PUBLIC_VARS.d.getlastid().ToString());
                l_Info.propmonenylenderInfoID = l_sid;
                l_Info.INSERT_DATATOLENDER();
                if(cboCivilStatus.Text != "Single"){
                    sp.propMoneyLender_id = l_sid;
                    sp.INSERT_SPOUSE();
                
                }
               
                Int64 dx = f.autoUserID() + 1;
                
                f.InsertCounterNo(dx);

                if (InsertPictureBarrowerImages == ""){
                    InsertPictureBarrowerImages = "default_avatar.jpg";
                }

                cMoneyLender.propPicBarrower = InsertPictureBarrowerImages;
                cMoneyLender.propMoneyLender_id = iiiD;
                cMoneyLender.InserPictureBarrower();

                MessageBox.Show(PUBLIC_VARS.saveData);

            }
            //cMoneyLender.LOAD_MONEYLENDER(lst.lsvMoneyLender);
            //MYFUNCTIONS m = new MYFUNCTIONS();
            //string sql = "SELECT * FROM tmoneylender";
            //m.PopulateListView(lsvevent,sql);
            cMoneyLender.LOAD_MONEYLENDER(lsvevent);
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime firstDate = DateTime.Now;


            DateTime dob1 = dob.Value;
            DateTime PresentYear = firstDate;
                    
         
           TimeSpan ts = PresentYear - dob1;
           int Age = ts.Days / 365;
         
           txtAge.Text = Age.ToString() ;//" Year" + "Month" +"Days"

        }

        private void spousedob_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void spousedob_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime firstDate = DateTime.Now;


            DateTime dob1 = spousedob.Value;
            DateTime PresentYear = firstDate;


            TimeSpan ts = PresentYear - dob1;
            int Age = ts.Days / 365;

            txtSpouseAge.Text = Age.ToString();//" Year" + "Month" +"Days"


        }

        private void cboCivilStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCivilStatus.Text == "Single"){
                txtspousename.Enabled = false;
                txtspousename.BackColor = Color.White;

            }
            else
            {
                txtspousename.Enabled = true;
                txtspousename.BackColor = Color.White;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
               // picBorrower.Image = new Bitmap(dlg.OpenFile());
               //string Chosen_File = dlg.FileName;
               //  onlyFileName = System.IO.Path.GetFileName(dlg.FileName);
               //  //MessageBox.Show(Chosen_File.ToString());
               //  InsertPictureBarrowerImages = Chosen_File;

                picBorrower.ImageLocation = dlg.FileName;
                picBorrower.SizeMode = PictureBoxSizeMode.StretchImage;
                namePictures = dlg.FileName;
            }
            dlg.Dispose();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            SaveFileDialog slg = new SaveFileDialog();
           
            slg.Title = "Save Image";
           // dlg.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            slg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            slg.Title = "Save an Image File";
            slg.InitialDirectory =@"D:\MY PROJECTS\LoanTrackingSystem\loantracking\loantracking\bimages";
            slg.RestoreDirectory = true;
           
            
            if (slg.ShowDialog() == DialogResult.OK)
            {
                string savePath = slg.FileName;
                try
                {
                    pictureBarrowerImages = System.IO.Path.GetFileName(saveFileDialog1.FileName);
                    picBorrower.SizeMode = PictureBoxSizeMode.StretchImage;
                    System.IO.FileStream fs = (System.IO.FileStream)slg.OpenFile();

                    //string path = savePath;
                    //string[] pathArr = path.Split('\\');
                    ////string[] fileArr = pathArr.Last().Split('.');
                    //string fileArr = pathArr.Last().ToString();
                    //string fileName = fileArr.Last().ToString();

                    savePath = System.IO.Path.GetFileName(slg.FileName);

                    switch (slg.FilterIndex)
                    {
                        case 1:
                            //this.btnSave.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg);
                            this.picBorrower.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);

                            InsertPictureBarrowerImages = savePath;
                            break;

                        case 2:
                            this.picBorrower.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            InsertPictureBarrowerImages = slg.FileName;
                            break;

                        case 3:
                            this.picBorrower.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                            InsertPictureBarrowerImages = slg.FileName;
                            break;
                    }
                    fs.Dispose(); 
               
                }
                catch (Exception hammer) { MessageBox.Show(hammer.Message); }
               
            }
        }
      
    }
}
