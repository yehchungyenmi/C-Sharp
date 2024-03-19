using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace yehchungyenprogram
{
    interface Show_Name
    {
        void Show_Personal_Name(String Name);
    }
    public enum CUST_Status //enum = enumeration 列與
    {
        Teacher,
        Clerk,
        Student,
        None_of_Above,
    }
    public class cust : Show_Name
    {
        public string ID;
        public string Name;
        public string Gender;
        public string Department;
        public CUST_Status Status;
        private uint Year_Status;
        public Image Obj_picture;
        public static int count = 0;
        public virtual void Public_Announcement()
        {
            MessageBox.Show("Message from CUST");
        }
        public void Show_Personal_Name(String Name)
        {
            MessageBox.Show("This CUST People's Name == "+ Name);
        }
        public uint My_Year_Status
        {
            get
            {
                return Year_Status;
            }
            set
            {
                Year_Status = value;
            }

        }
        public cust(string ID,string Name,string Department,string Gender,uint Year_Status,CUST_Status My_Status,Image New_Picture)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Department = Department;
            this.Year_Status = Year_Status;
            this.Status = My_Status;
            this.Obj_picture = New_Picture;
        }
        public static CUST_Status Get_Status(string Status_String)
        {
            if ((Status_String == "Teacher") || (Status_String == "teacher"))
                return CUST_Status.Teacher;
            else if ((Status_String == "Clerk") || (Status_String == "clerk"))
                return CUST_Status.Clerk;
            else if ((Status_String == "Student") || (Status_String == "student") || (Status_String == "學生"))
                return CUST_Status.Student;
            else
            {
                MessageBox.Show("Status Wrong");
                return CUST_Status.None_of_Above;
            }
        }
        public static void Add_people()
        {
            count++;
        }
        public static void remove_people()
        {
            count--;
        }
    }
}
