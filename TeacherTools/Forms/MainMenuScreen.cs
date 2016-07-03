using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
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
            StudentScreen studentModuleScreen = new StudentScreen(_appRepository, _resource);
            studentModuleScreen.Show();
        }

        private void classListMenuBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
