using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProjectMVC.Models
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Campany> Companys { get; set; }
        public DbSet<ApplyForJob> ApplyForJobs { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Insert Category data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Software Development", Description = "Software development related jobs" },
                new Category { Id = 2, Name = "UI/UX Design", Description = "UI/UX design related jobs" },
                new Category { Id = 3, Name = "Software Testing", Description = "Software Testing  related jobs" },
                new Category { Id = 4, Name = "Data Science", Description = "Data Science related jobs" },
                new Category { Id = 5, Name = "Digital Marketing", Description = "Digital Marketing related jobs" },
                new Category { Id = 6, Name = "Graphic Design", Description = "Graphic Design related jobs" },
                new Category { Id = 7, Name = "Financial Services", Description = "Financial Services related jobs" },
                new Category { Id = 8, Name = "Healthcare", Description = "Healthcare related jobs" },
                new Category { Id = 9, Name = "Education", Description = "Education related jobs" },
                new Category { Id = 10, Name = "Sales", Description = "Sales related jobs" },
                new Category { Id = 11, Name = "Customer Support", Description = "Customer Support related jobs" }
            );

            //Insert Job data
            modelBuilder.Entity<Job>().HasData(
               new Job
               {
                   Id = 1,
                   Name = "Software Engineer",
                   Description = "Develop software applications",
                   CategoryId = 1,
                   Type = "Full Time",
                   Position = "Employee",
                   Location = "Assiut",
                   Salary = 50000,
                   DateTime = new DateTime(2023, 12, 4),
                   Qualifications= "Qualifications for a software engineer typically include ,a bachelor's degree in computer science, software engineering, or a related field. Some employers may also require a master's degree for more advanced positions. In addition to formal education, relevant skills in programming languages, software development, problem-solving, and teamwork are essential. Many software engineers also benefit from industry certifications and continuous learning to stay updated with the latest technologies and best practices.",
                   Responsibility= "The responsibilities of a software engineer often include, designing, developing, and testing software solutions, as well as collaborating with cross-functional teams to understand requirements and deliver high-quality products. Software engineers are also responsible for maintaining and enhancing existing software, debugging and troubleshooting issues, and staying updated with industry best practices and technological advancements. Additionally, they may be involved in documenting software specifications, providing technical support, and participating in code reviews to ensure quality and efficiency."
               },
               new Job
               {
                   Id = 3,
                   Name = "Software Developer",
                   Description = "Develop software solutions",
                   CategoryId = 1,
                   Type = "Part Time",
                   Position = "Developer",
                   Location = "Cario",
                   Salary = 9800,
                   DateTime = new DateTime(2024, 1, 4),
                   Qualifications = "Qualifications for a software developer typically include a bachelor's degree in computer science, software engineering, or a related field. Strong programming skills, knowledge of software development methodologies, and the ability to work in a team environment are essential. Some employers may also prefer candidates with experience in specific programming languages and tools, as well as a strong understanding of software design principles and best practices.",
                   Responsibility = "The responsibilities of a software developer often include participating in the entire software development lifecycle, from concept and design to testing and maintenance. Software developers collaborate with stakeholders to understand requirements, write clean and efficient code, troubleshoot and debug software issues, and continuously improve software functionality. They may also be involved in documenting software specifications, conducting code reviews, and staying updated with industry trends and advancements."
               },
                               new Job
                               {
                                   Id = 4,
                                   Name = "Software Engineer",
                                   Description = "Engineer software systems",
                                   CategoryId = 1,
                                   Type = "Full Time",
                                   Position = "Engineer",
                                   Location = "SmartVillage",
                                   Salary = 12000,
                                   DateTime = new DateTime(2024, 12, 4),
                                   Qualifications = "Bachelor's or master's degree in Computer Science, Software Engineering, or related field. Proven experience in software development methodologies and best practices. Proficient in multiple programming languages and frameworks relevant to the organization's tech stack. Strong analytical and problem-solving skills. Excellent communication and teamwork abilities.",
                                   Responsibility = "Design, develop, test, and maintain software systems to meet client or stakeholder requirements. Collaborate with team members to identify system requirements and integrate software components. Write clean, scalable, and efficient code. Troubleshoot, debug, and upgrade existing systems. Document development phases and monitor systems."
                               },
                new Job
                {
                    Id = 5,
                    Name = "Backend Developer",
                    Description = "Work on backend systems",
                    CategoryId = 1,
                    Type = "Part Time",
                    Position = "Developer",
                    Location = "Sohag",
                    Salary = 30000,
                    DateTime = new DateTime(2024, 9, 3),
                    Qualifications = "Bachelor's degree in Computer Science or related field. Strong understanding of server-side languages such as Java, Python, Ruby, .NET, etc. Experience with database technology such as MySQL, Oracle, and MongoDB. Familiarity with cloud services and API integration. Excellent problem-solving skills and ability to think algorithmically.",
                    Responsibility = "Develop and maintain the server-side logic of web applications and databases. Ensure high performance and responsiveness to requests from the front-end. Participate in the entire application lifecycle, focusing on coding, debugging, and providing user support. Create data protection and security settings. Write technical documentation."
                },
                new Job
                {
                    Id = 6,
                    Name = "Frontend Developer",
                    Description = "Develop user interfaces",
                    CategoryId = 1,
                    Type = "Full Time",
                    Position = "Developer",
                    Location = "Minya",
                    Salary = 9800,
                    DateTime = new DateTime(2023, 1, 4),
                    Qualifications = "Bachelor's degree in Computer Science, or similar. Proficiency with HTML, CSS, and JavaScript. Experience with front-end development frameworks (e.g., React, Angular, Vue). Understanding of web design principles and UX/UI best practices. Familiarity with version control tools like Git.",
                    Responsibility = "Develop new user-facing features and build reusable code and libraries for future use. Ensure the technical feasibility of UI/UX designs. Optimize application for maximum speed and scalability. Assure that all user input is validated before submitting to back-end services. Collaborate with other team members and stakeholders."
                },

           //////
           new Job
           {
               Id = 2,
               Name = "UI Designer",
               Description = "Design user interfaces",
               CategoryId = 2,
               Type = "Part time",
               Position = "Team Lead",
               Location = "Assiut",
               Salary = 98000,
               DateTime = new DateTime(2024, 11, 4),
               Qualifications = "Proven experience as a UI Designer or similar role. Strong portfolio of design projects. Proficiency in visual design and wire-framing tools. Knowledge of HTML/CSS; JavaScript is a plus. Problem-solving mindset and a keen eye for detail.",
               Responsibility = "Gather and evaluate user requirements in collaboration with product managers and engineers. Design graphic user interface elements, like menus, tabs, and widgets. Develop UI mockups and prototypes that clearly illustrate how sites function and look. Adhere to style standards on fonts, colors, and images. Provide guidance and mentorship to junior team members."
           },
            new Job
            {
                Id = 7,
                Name = "Graphic Designer",
                Description = "Design user interfaces",
                CategoryId = 2,
                Type = "Full Time",
                Position = "Designer",
                Location = "Minyfia",
                Salary = 40000,
                DateTime = new DateTime(2024, 12, 4),
                Qualifications = "Bachelor's degree in Graphic Design or related field. Proven graphic designing experience with a strong portfolio. Proficiency in Photoshop, Illustrator, InDesign, and other visual design and wire-framing tools. Exceptional creativity and innovation. Excellent time management and organizational skills.",
                Responsibility = "Conceptualize visuals based on requirements. Prepare rough drafts and present ideas. Develop illustrations, logos, and other designs using software. Use appropriate colors and layouts for each graphic. Work with copywriters and creative director to produce the final design."
            },
            new Job
            {
                Id = 8,
                Name = "UX Designer",
                Description = "Create user experiences",
                CategoryId = 2,
                Type = "Full Time",
                Position = "Designer",
                Location = "Alexandria",
                Salary = 9000,
                DateTime = new DateTime(2024, 3, 4),
                Qualifications = "Strong understanding of UX principles and best practices. Experience with user research, wireframes, and prototypes. Proficiency in UX design software such as Sketch, Adobe XD, or Figma. Excellent communication skills to collaborate with team members and stakeholders. Ability to solve problems creatively and effectively.",
                Responsibility = "Conduct user research and testing. Develop wireframes and task flows based on user needs. Collaborate with designers and developers to create intuitive, user-friendly software. Communicate design ideas and prototypes to developers. Keep abreast of competitor products and industry trends."
            },
            new Job
            {
                Id = 9,
                Name = "Interaction Designer",
                Description = "Design interactive interfaces",
                CategoryId = 2,
                Type = "Full Time",
                Position = "Designer",
                Location = "Cairo",
                Salary = 9800,
                DateTime = new DateTime(2024, 1, 4),
                Qualifications = "Bachelor's degree in Design, Computer Science, or relevant field. Proven experience as an Interaction Designer or similar role. Strong portfolio of design projects. Proficient in design software and interactive design tools. Excellent communication skills to collaborate with various stakeholders.",
                Responsibility = "Develop interactive design elements and architecture for digital platforms. Create user-focused concepts and interactive solutions. Work closely with UI designers and developers to implement interactive designs. Test and refine designs based on user feedback and data. Stay updated with the latest trends in interaction design and technology."
            },
            new Job
            {
                Id = 10,
                Name = "Visual Designer",
                Description = "Focus on visual aspects of design",
                CategoryId = 2,
                Type = "Part Time",
                Position = "Designer",
                Location = "Elgharbia",
                Salary = 9800,
                DateTime = new DateTime(2024, 1, 4),
                Qualifications = "Proven experience as a Visual Designer, Graphic Designer, or similar role. Strong portfolio of visual design projects. Proficiency in graphic design software including Adobe Photoshop, Adobe Illustrator, and other visual design tools. Excellent visual design skills with sensitivity to user-system interaction. Ability to present and defend designs and key deliverables to peers and executive level stakeholders.",
                Responsibility = "Develop visual elements for websites, applications, and other digital platforms. Create images, icons, and layouts according to design guidelines. Work with the design team to define and implement innovative solutions for the product direction, visuals, and experience. Execute all visual design stages from concept to final hand-off to engineering. Conceptualize original ideas that bring simplicity and user friendliness to complex design roadblocks."
            },

                // Jobs for Software Testing category
                // Jobs for Software Testing category with qualifications and responsibilities
                new Job
                {
                    Id = 11,
                    Name = "QA Tester",
                    Description = "Test software applications",
                    CategoryId = 3,
                    Type = "Part Time",
                    Position = "Tester",
                    Location = "Cario",
                    Salary = 9400,
                    DateTime = new DateTime(2024, 1, 4),
                    Qualifications = "Qualifications for a QA Tester include a bachelor's degree in computer science, information technology, or a related field. Proficiency in various testing methodologies and tools, attention to detail, and strong analytical skills are essential. Experience with automated testing tools and a basic understanding of programming languages are advantageous.",
                    Responsibility = "Responsibilities of a QA Tester involve designing, developing, and executing test cases to ensure the quality of software applications. They detect bugs and issues, provide detailed bug reports, and collaborate with the development team to resolve issues. QA Testers also participate in the development process to understand requirements and ensure compliance with quality standards."
                },
                new Job
                {
                    Id = 12,
                    Name = "Automation Tester",
                    Description = "Automate testing processes",
                    CategoryId = 3,
                    Type = "Full Time",
                    Position = "Tester",
                    Location = "Cario",
                    Salary = 9800,
                    DateTime = new DateTime(2024, 1, 4),
                    Qualifications = "Qualifications for an Automation Tester include a bachelor’s degree in computer science, engineering, or related field. Strong programming skills and experience with automation tools like Selenium or QTP are required. Understanding of software development methodologies and experience with CI/CD tools are beneficial.",
                    Responsibility = "Responsibilities include designing and implementing automated testing frameworks, writing and executing test scripts, identifying and logging defects, and working with the development team to resolve them. Automation Testers also maintain and enhance test automation environments and integrate automation tests with the CI/CD pipeline."
                },
                new Job
                {
                    Id = 13,
                    Name = "Performance Tester",
                    Description = "Test software performance",
                    CategoryId = 3,
                    Type = "Full Time",
                    Position = "Tester",
                    Location = "Assiut",
                    Salary = 29200,
                    DateTime = new DateTime(2023, 11, 22),
                    Qualifications = "Qualifications include a bachelor's degree in computer science or a related field, with a strong understanding of performance testing methodologies and tools (e.g., LoadRunner, JMeter). Knowledge of programming and scripting languages, and experience with system monitoring tools are important.",
                    Responsibility = "Responsibilities involve planning, designing, and implementing performance tests to ensure software applications meet performance criteria. This includes analyzing test results, identifying bottlenecks, and working closely with developers to optimize performance."
                },
                new Job
                {
                    Id = 14,
                    Name = "Quality Analyst",
                    Description = "Analyze software quality",
                    CategoryId = 3,
                    Type = "Full Time",
                    Position = "Analyst",
                    Location = "Cairo",
                    Salary = 29900,
                    DateTime = new DateTime(2023, 11, 22),
                    Qualifications = "Qualifications for a Quality Analyst include a bachelor's degree in computer science, IT, or a related field, with a deep understanding of QA methodologies. Strong analytical skills, attention to detail, and experience with QA tools and processes are essential.",
                    Responsibility = "The main responsibilities include analyzing software products to ensure they meet quality standards and user requirements. This involves developing and executing test plans, documenting defects, and collaborating with development teams to resolve issues."
                },
                // Jobs for Data Science category with qualifications and responsibilities
                new Job
                {
                    Id = 15,
                    Name = "Data Scientist",
                    Description = "Analyzing complex data sets",
                    CategoryId = 4,
                    Type = "Full Time",
                    Position = "Scientist",
                    Location = "Assiut",
                    Salary = 29200,
                    DateTime = new DateTime(2023, 11, 22),
                    Qualifications = "A Data Scientist typically holds a master’s or Ph.D. in data science, statistics, computer science, or a related field. Essential skills include proficiency in programming languages like Python or R, experience with data visualization tools, and a strong foundation in machine learning and statistical analysis.",
                    Responsibility = "Responsibilities include collecting, processing, and analyzing large data sets to identify trends and patterns. Data Scientists develop predictive models, algorithms, and conduct experiments to test their effectiveness. They also communicate findings to stakeholders and provide insights to inform decision-making."
                },
                new Job
                {
                    Id = 16,
                    Name = "Machine Learning Engineer",
                    Description = "Implement machine learning algorithms",
                    CategoryId = 4,
                    Type = "Part Time",
                    Position = "Engineer",
                    Location = "Assiut",
                    Salary = 29200,
                    DateTime = new DateTime(2023, 11, 22),
                    Qualifications = "Qualifications include a degree in computer science, mathematics, or a related technical field. Proficiency in programming languages such as Python or Java, and experience with machine learning frameworks (e.g., TensorFlow, PyTorch) are required. A strong mathematical background is also important.",
                    Responsibility = "Machine Learning Engineers are responsible for designing and implementing machine learning models. They work on data preprocessing, model training, testing, and deployment. Collaborating with data scientists and software engineers to integrate models into production systems is also part of their role."
                },
                new Job
                {
                    Id = 17,
                    Name = "Data Analyst",
                    Description = "Analyze data to extract insights",
                    CategoryId = 4,
                    Type = "Full Time",
                    Position = "Analyst",
                    Location = "Assiut",
                    Salary = 29200,
                    DateTime = new DateTime(2023, 11, 22),
                    Qualifications = "A Data Analyst typically holds a bachelor's degree in information technology, computer science, or a related field. Proficiency in SQL, Excel, and data visualization tools like Tableau or Power BI is required. Analytical thinking and problem-solving skills are essential.",
                    Responsibility = "Data Analysts collect and interpret data to identify trends, patterns, and insights. They create reports and dashboards for stakeholders, helping to drive decision-making and strategic planning. Ensuring data accuracy and providing recommendations based on data analysis are key responsibilities."
                },
new Job
{
    Id = 18,
    Name = "Big Data Engineer",
    Description = "Manage and analyze large data sets",
    CategoryId = 4,
    Type = "Part Time",
    Position = "Engineer",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Computer Science or related field\nExperience with big data technologies\nStrong analytical skills",
    Responsibility = "Develop and manage big data solutions\nAnalyze data sets to identify insights\nEnsure data security and privacy"
},

new Job
{
    Id = 19,
    Name = "Digital Marketing Specialist",
    Description = "Plan and execute digital marketing campaigns",
    CategoryId = 5,
    Type = "Full Time",
    Position = "Specialist",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Marketing or related field\nExperience with digital marketing tools and platforms\nStrong communication and analytical skills",
    Responsibility = "Plan and execute digital marketing campaigns\nMonitor and analyze campaign performance\nCollaborate with other teams to integrate marketing strategies"
},

new Job
{
    Id = 20,
    Name = "SEO Analyst",
    Description = "Optimize websites for search engines",
    CategoryId = 5,
    Type = "Full Time",
    Position = "Analyst",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Proven experience as SEO Analyst\nKnowledge of SEO practices and analytics tools\nExcellent communication skills",
    Responsibility = "Perform ongoing keyword research\nOptimize website content for search engines\nTrack and analyze website analytics"
},

new Job
{
    Id = 21,
    Name = "Social Media Manager",
    Description = "Manage social media presence",
    CategoryId = 5,
    Type = "Full Time",
    Position = "Manager",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Experience with social media management\nStrong communication and creative skills\nAbility to analyze performance metrics",
    Responsibility = "Develop and implement social media strategy\nCreate and distribute engaging content\nMonitor and report on performance metrics"
},

new Job
{
    Id = 22,
    Name = "Content Marketing Specialist",
    Description = "Create engaging content for marketing purposes",
    CategoryId = 5,
    Type = "Part Time",
    Position = "Specialist",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Proven content creation experience\nExcellent writing and editing skills\nUnderstanding of marketing strategies",
    Responsibility = "Develop content strategy aligned with marketing targets\nCreate and publish engaging content\nAnalyze content performance and adjust strategies as needed"
},
new Job
{
    Id = 24,
    Name = "Graphic Designer",
    Description = "Create visual concepts",
    CategoryId = 6,
    Type = "Full Time",
    Position = "Designer",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Graphic Design or related field\nProficiency in graphic design software\nCreative thinking and attention to detail",
    Responsibility = "Create visual aspects of marketing materials, websites, and other media\nWork with clients or the art director to determine the scope of a project\nUse digital illustration, photo editing software, and layout software to create designs"
},

new Job
{
    Id = 25,
    Name = "Illustrator",
    Description = "Create illustrations and graphics",
    CategoryId = 6,
    Type = "Part Time",
    Position = "Illustrator",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Strong portfolio of illustrations or other graphics\nFamiliarity with design software and technologies\nA keen eye for aesthetics and details",
    Responsibility = "Create original pieces of artwork for digital or print\nUse various colors, graphics and effects to better visualize each concept\nParticipate in design briefs with clients, editors, or marketers to identify their needs"
},

new Job
{
    Id = 26,
    Name = "Art Director",
    Description = "Oversee visual aspects of projects",
    CategoryId = 6,
    Type = "Full Time",
    Position = "Director",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Proven experience as an Art Director\nStrong portfolio showcasing high-end digital design skills\nAbility to think creatively and provide marketable solutions",
    Responsibility = "Determine the best way to represent a concept visually\nDecide which photographs, art, or other design elements to use\nDevelop the overall look or style of a publication, an advertising campaign, or a theater, television, or film set"
},

new Job
{
    Id = 27,
    Name = "Motion Graphics Designer",
    Description = "Create animated graphics and visual effects",
    CategoryId = 6,
    Type = "Part Time",
    Position = "Designer",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Demonstrable graphic design skills with a strong portfolio\nProficiency with required desktop publishing tools, including Photoshop, After Effects, and Adobe Animate\nA strong eye for visual composition",
    Responsibility = "Design and create enticing motion graphics for video deliverables (corporate videos, websites, marketing demos, etc.)\nPrepare design plan, concept, and layout for motion graphic project\nAssist in selecting audio, video, colors, animation, etc. for graphic design"
},

               new Job
               {
                   Id = 28,
                   Name = "Financial Analyst",
                   Description = "Analyze financial data and trends",
                   CategoryId = 7,
                   Type = "Full Time",
                   Position = "Analyst",
                   Location = "Assiut",
                   Salary = 29200,
                   DateTime = new DateTime(2023, 11, 22),
                   Qualifications = "Bachelor's degree in Finance, Accounting, or related field\nExperience with financial modeling and statistical analysis\nStrong analytical and data gathering skills",
                   Responsibility = "Analyze financial data to identify trends and make recommendations\nPrepare financial reports and forecasts\nEvaluate investment opportunities and provide recommendations"
               },

new Job
{
    Id = 29,
    Name = "Investment Banker",
    Description = "Manage investment portfolios",
    CategoryId = 7,
    Type = "Part Time",
    Position = "Banker",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Finance, Economics, or related field\nStrong analytical and quantitative skills\nExcellent communication and interpersonal skills",
    Responsibility = "Advise clients on investment opportunities and strategies\nManage and structure financial deals\nConduct financial analysis and market research"
},

new Job
{
    Id = 30,
    Name = "Financial Advisor",
    Description = "Provide financial advice to clients",
    CategoryId = 7,
    Type = "Full Time",
    Position = "Advisor",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Finance, Economics, or a related field\nCertification as a Certified Financial Planner (CFP) preferred\nStrong understanding of the financial market and investment strategies",
    Responsibility = "Assess clients' financial situations and understand their needs\nProvide personalized financial advice and investment solutions\nMonitor and review clients' accounts and adjust plans as necessary"
},

new Job
{
    Id = 31,
    Name = "Accountant",
    Description = "Manage financial records and statements",
    CategoryId = 7,
    Type = "Full Time",
    Position = "Accountant",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Bachelor's degree in Accounting or related field\nCertification (e.g., CPA) is a plus\nProven experience as an accountant",
    Responsibility = "Prepare accurate financial statements and reports\nEnsure compliance with financial laws and regulations\nManage all accounting transactions and audit financial transactions and documents"
},

              new Job
              {
                  Id = 32,
                  Name = "Registered Nurse",
                  Description = "Provide patient care",
                  CategoryId = 8,
                  Type = "Full Time",
                  Position = "Nurse",
                  Location = "Assiut",
                  Salary = 29200,
                  DateTime = new DateTime(2023, 11, 22),
                  Qualifications = "Bachelor of Science in Nursing (BSN) degree\nActive Registered Nurse license\nProven experience as a registered nurse",
                  Responsibility = "Provide direct patient care and assess their conditions\nAdminister medications and treatments\nEducate patients and their families on health plans and preventive care"
              },

new Job
{
    Id = 33,
    Name = "Medical Doctor",
    Description = "Diagnose and treat medical conditions",
    CategoryId = 8,
    Type = "Full Time",
    Position = "Doctor",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Medical degree from a recognized university\nValid license to practice the profession\nProven experience as a Medical Doctor",
    Responsibility = "Diagnose patient conditions using examinations and tests\nPrescribe and administer treatment\nAdvise patients on health and preventive care"
},

new Job
{
    Id = 34,
    Name = "Medical Assistant",
    Description = "Assist healthcare professionals",
    CategoryId = 8,
    Type = "Full Time",
    Position = "Assistant",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Proven experience as a medical assistant or in a similar role\nKnowledge of healthcare operations and medical terminology\nStrong organizational and communication skills",
    Responsibility = "Assist in examining and treating patients under the direction of a physician\nPrepare patients for examinations and perform routine diagnostic checks\nManage medical supplies and keep detailed records of all patient interactions"
},

new Job
{
    Id = 35,
    Name = "Pharmacist",
    Description = "Dispense medications and provide information",
    CategoryId = 8,
    Type = "Full Time",
    Position = "Pharmacist",
    Location = "Assiut",
    Salary = 29200,
    DateTime = new DateTime(2023, 11, 22),
    Qualifications = "Degree in Pharmacy or Pharmacology\nValid pharmacist license\nProven experience as a pharmacist",
    Responsibility = "Dispense medications accurately and ensure safety and quality standards are met\nProvide information to patients about medications and their use\nManage inventory and perform administrative tasks"
},

               // Jobs for Education category
               new Job { Id = 36, Name = "Teacher", Description = "Educate students in a specific subject area", CategoryId = 9, Type = "Full Time", Position = "Teacher", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 37, Name = "Principal", Description = "Oversee school operations and staff", CategoryId = 9, Type = "Full Time", Position = "Principal", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 38, Name = "Guidance Counselor", Description = "Provide academic and personal guidance to students", CategoryId = 9, Type = "Full Time", Position = "Counselor", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 39, Name = "Librarian", Description = "Manage library resources and assist patrons", CategoryId = 9, Type = "Full Time", Position = "Librarian", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },

               // Jobs for Sales category
               new Job { Id = 40, Name = "Sales Representative", Description = "Sell products or services to customers", CategoryId = 10, Type = "Full Time", Position = "Representative", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 41, Name = "Sales Manager", Description = "Oversee sales team and strategies", CategoryId = 10, Type = "Full Time", Position = "Manager", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 42, Name = "Account Executive", Description = "Manage client accounts and relationships", CategoryId = 10, Type = "Full Time", Position = "Executive", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 43, Name = "Business Development Representative", Description = "Identify and develop business opportunities", CategoryId = 10, Type = "Full Time", Position = "Representative", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },

               // Jobs for Customer Support category
               new Job { Id = 44, Name = "Customer Support Specialist", Description = "Assist customers with product inquiries and issues", CategoryId = 11, Type = "Full Time", Position = "Specialist", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 45, Name = "Technical Support Engineer", Description = "Provide technical assistance to customers", CategoryId = 11, Type = "Full Time", Position = "Engineer", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 46, Name = "Customer Service Representative", Description = "Handle customer inquiries and complaints", CategoryId = 11, Type = "Full Time", Position = "Representative", Location = "Assiut", Salary = 29200, DateTime = new DateTime(2023, 11, 22) },
               new Job { Id = 47, Name = "Support Manager", Description = "Manage customer support team and operations", CategoryId = 11, Type = "Full Time", Position = "Manager", Location = "Luxor", Salary = 29200, DateTime = new DateTime(2023, 11, 22) }
           );

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
           UseSqlServer("Data Source=.;Initial Catalog=ProjectMVC4;Integrated Security=True;Trust Server Certificate = False;Encrypt = False;");
        }




    }
}
