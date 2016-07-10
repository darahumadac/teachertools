using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Models.AppModels;
using Models.Repositories;
using TeacherTools.Repositories;

namespace TeacherTools.Forms
{
    public partial class MainMenuScreen : Form
    {
        private ResourceManager _resource;
        private TeacherToolsDbContext _appDbContext;
        private SqlRepository _appRepository;

        public MainMenuScreen()
        {
            _resource = new ResourceManager("TeacherTools.TeacherToolsResource", Assembly.GetExecutingAssembly());
            _appDbContext = new TeacherToolsDbContext();
            _appRepository = new SqlRepository(_appDbContext);

            InitializeComponent();

        }

        private void studentsListMenuBtn_Click(object sender, EventArgs e)
        {
            IRepository<Student> studentRepository = _appRepository;
            StudentManager studentManager = new StudentManager(studentRepository);

            StudentMainScreen studentMainScreen =
                new StudentMainScreen(_resource, studentManager, typeof(StudentInfoScreen));

            studentMainScreen.Show();
        }

        private void classListMenuBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
