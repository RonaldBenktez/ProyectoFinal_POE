using BusinessLayer.Services;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    //Forms
                    services.AddTransient<LoginForm>();
                    services.AddTransient<HomeForm>();
                    services.AddTransient<MembersForm>();
                    services.AddTransient<GradesAndSectionsForm>();
                    services.AddTransient<SubjectsForm>();
                    services.AddTransient<TeacherClassForm>();
                    services.AddTransient<AddNotesForm>();
                    services.AddTransient<ViewNotesStudentsForm>();
                    services.AddTransient<ViewStudentsClassForm>();

                    //Repositories
                    services.AddScoped<IMembersLoginRepository, MemberLoginsRepository>();
                    services.AddScoped<IMembersRepository, MembersRepository>();
                    services.AddScoped<ISubjectRepository, SubjectRepository>();
                    services.AddScoped<IClassesRepository, ClassesRepository>();
                    services.AddScoped<IEnrollStudentRepository, EnrollStudentRepository>();
                    services.AddScoped<INotesRepository, NotesRepository>();
                    services.AddScoped<IStudentRepository, StudentRepository>();

                    //Services
                    services.AddScoped<ILoginServices, MembersLoginServices>();
                    services.AddScoped<IMembersServices, MembersServices>();
                    services.AddScoped<ISubjectServices, SubjectServices>();
                    services.AddScoped<IClassesServices, ClassesServices>();
                    services.AddScoped<IEnrollStudentServices, EnrollStudentServices>();
                    services.AddScoped<INotesServices, NotesServices>();
                    services.AddScoped<IStudentServices, StudentServices>();


                    //Connection
                    services.AddSingleton<ISqlConnect, SqlConnect>();


                });
        }
    }
}