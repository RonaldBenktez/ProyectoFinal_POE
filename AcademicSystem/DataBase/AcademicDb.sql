USE [master]
GO

CREATE DATABASE [AcademicAdministrator]
GO

USE [AcademicAdministrator]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NOT NULL,
	[TeacherId] [int] NOT NULL,
	[ClassContent] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[EnrollmentsId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EnrollmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[GradeId] [int] IDENTITY(1,1) NOT NULL,
	[GradeName] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[RolId] [int] NOT NULL,
	[Names] [varchar](100) NOT NULL,
	[LastNames] [varchar](100) NOT NULL,
	[MemberUser] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
	[DateEntry] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notes]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notes](
	[NoteId] [int] IDENTITY(1,1) NOT NULL,
	[EnrollmentsId] [int] NOT NULL,
	[Note1] [decimal](18, 2) NULL,
	[Note2] [decimal](18, 2) NULL,
	[FinalNote] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[NoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[RoleType] [varchar](50) NOT NULL,
	[RoleDescription] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[SectionName] [varchar](50) NOT NULL,
	[GradeId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](100) NOT NULL,
	[SectionId] [int] NOT NULL,
	[Year] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeacherAndSubjects]    Script Date: 28/11/2024 02:23:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherAndSubjects](
	[TeacherAndSubjectId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherAndSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([ClassId], [SubjectId], [TeacherId], [ClassContent]) VALUES (9, 3, 1, N'introduccion')
INSERT [dbo].[Classes] ([ClassId], [SubjectId], [TeacherId], [ClassContent]) VALUES (1010, 4, 1, N'java script')
INSERT [dbo].[Classes] ([ClassId], [SubjectId], [TeacherId], [ClassContent]) VALUES (1011, 4, 1, N'css')
SET IDENTITY_INSERT [dbo].[Classes] OFF
GO
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([GradeId], [GradeName]) VALUES (1, N'primer grado')
INSERT [dbo].[Grades] ([GradeId], [GradeName]) VALUES (2, N'segundo grado')
INSERT [dbo].[Grades] ([GradeId], [GradeName]) VALUES (3, N'tercer grado')
SET IDENTITY_INSERT [dbo].[Grades] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([MemberId], [RolId], [Names], [LastNames], [MemberUser], [Password], [Email], [Phone], [DateEntry]) VALUES (1, 1, N'Jose Luis', N'Zelaya Hernandez', N'luis', N'1234', N'luis@gmial.com', N'34975217', CAST(N'2024-11-27T10:24:07.607' AS DateTime))
INSERT [dbo].[Members] ([MemberId], [RolId], [Names], [LastNames], [MemberUser], [Password], [Email], [Phone], [DateEntry]) VALUES (15, 3, N'juan carlos', N'hernandez cortez', N'juan2024', N'j1234', N'juan@gmail.com', N'47869034', CAST(N'2024-11-28T02:15:55.537' AS DateTime))
INSERT [dbo].[Members] ([MemberId], [RolId], [Names], [LastNames], [MemberUser], [Password], [Email], [Phone], [DateEntry]) VALUES (16, 2, N'pedro antonio', N'castro martinez', N'pedro2024', N'p1234', N'pedro@gmail.com', N'58963458', CAST(N'2024-11-28T02:12:53.113' AS DateTime))
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RolId], [RoleType], [RoleDescription]) VALUES (1, N'Docente', N'Encargado de impartir clases y gestion del sistema')
INSERT [dbo].[Roles] ([RolId], [RoleType], [RoleDescription]) VALUES (2, N'Estudiante', N'Recibe las clases impartidas por los docentes')
INSERT [dbo].[Roles] ([RolId], [RoleType], [RoleDescription]) VALUES (3, N'Administrador', N'encargado de controlar todo el sistema')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([SectionId], [SectionName], [GradeId]) VALUES (1, N'a', 1)
INSERT [dbo].[Sections] ([SectionId], [SectionName], [GradeId]) VALUES (3, N'c', 3)
INSERT [dbo].[Sections] ([SectionId], [SectionName], [GradeId]) VALUES (2, N'f', 1)
SET IDENTITY_INSERT [dbo].[Sections] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [SectionId], [Year]) VALUES (3, N'ingles', 3, 2024)
INSERT [dbo].[Subjects] ([SubjectId], [SubjectName], [SectionId], [Year]) VALUES (4, N'programacion', 2, 2024)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
/****** Object:  Index [UQ_Student_Subject]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[Enrollments] ADD  CONSTRAINT [UQ_Student_Subject] UNIQUE NONCLUSTERED 
(
	[StudentId] ASC,
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_GradeName]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[Grades] ADD  CONSTRAINT [UQ_GradeName] UNIQUE NONCLUSTERED 
(
	[GradeName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_MemberUser]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[Members] ADD  CONSTRAINT [UQ_MemberUser] UNIQUE NONCLUSTERED 
(
	[MemberUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_SectionAndGrade]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[Sections] ADD  CONSTRAINT [UQ_SectionAndGrade] UNIQUE NONCLUSTERED 
(
	[SectionName] ASC,
	[GradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_SubjectsAndSections]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[Subjects] ADD  CONSTRAINT [UQ_SubjectsAndSections] UNIQUE NONCLUSTERED 
(
	[SubjectName] ASC,
	[SectionId] ASC,
	[Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__TeacherA__F2C4863F8948EF00]    Script Date: 28/11/2024 02:23:39 a. m. ******/
ALTER TABLE [dbo].[TeacherAndSubjects] ADD UNIQUE NONCLUSTERED 
(
	[SubjectId] ASC,
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Notes] ADD  DEFAULT ((0.0)) FOR [Note1]
GO
ALTER TABLE [dbo].[Notes] ADD  DEFAULT ((0.0)) FOR [Note2]
GO
ALTER TABLE [dbo].[Notes] ADD  DEFAULT ((0.0)) FOR [FinalNote]
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([SubjectId])
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Members] ([MemberId])
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD FOREIGN KEY([StudentId])
REFERENCES [dbo].[Members] ([MemberId])
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[TeacherAndSubjects] ([TeacherAndSubjectId])
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD FOREIGN KEY([RolId])
REFERENCES [dbo].[Roles] ([RolId])
GO
ALTER TABLE [dbo].[Notes]  WITH CHECK ADD FOREIGN KEY([EnrollmentsId])
REFERENCES [dbo].[Enrollments] ([EnrollmentsId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD FOREIGN KEY([GradeId])
REFERENCES [dbo].[Grades] ([GradeId])
GO
ALTER TABLE [dbo].[TeacherAndSubjects]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([SubjectId])
GO
ALTER TABLE [dbo].[TeacherAndSubjects]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Members] ([MemberId])
GO
