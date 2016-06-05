select * from TrainingCategory

--insert into TrainingCategory (Description) values ('Big Data')

select * from TrainingSubject

select * from TrainingSubjectCategory

insert into TrainingSubjectCategory (Description, TrainingCategoryID) values ('Big Data Development', 4)
insert into TrainingSubjectCategory (Description, TrainingCategoryID) values ('Big Data Administration', 4)

select * from TrainingCourse

insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Hadoop Developer Training', 9)
insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Design, Develope and Build Big Data Application', 9)
insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Hive and PIG Training', 9)
insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Spark Training', 9)

insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Hadoop Administrator Training', 10)
insert into TrainingSubject (SubjectName, TrainingSubjectCategoryID) values('Data Scientist Training', 10)

select * from Syllabus

insert into Syllabus (Description) values ('Hadoop basic concepts')
insert into Syllabus (Description) values ('Introduction to Hadoop Distributed File System')
insert into Syllabus (Description) values ('What is MapReduce')
insert into Syllabus (Description) values ('Custom Partitioners')
insert into Syllabus (Description) values ('Custom Writables and WritableComparables')
insert into Syllabus (Description) values ('Custom InputFormats and OutputFormats')
insert into Syllabus (Description) values ('Introduction to Coomon MapReduce algorithms')
insert into Syllabus (Description) values ('Explaining Hive and Pig')
insert into Syllabus (Description) values ('Introduction to Sqoop and Flume')
insert into Syllabus (Description) values ('Oozie')
insert into Syllabus (Description) values ('Machine Learning and Mahout')

insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 159)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 160)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 161)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 162)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 163)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 164)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 165)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 166)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 167)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 168)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (24, 169)

select * from TrainingCourse

insert into TrainingCourse (TrainingSubjectID, StartDate, EndDate, Location) values(24, '2015-01-01', '2015-03-01', 'Bothell')


select * from PreRequisite

select * from TrainingSubjectPreRequisite

insert into PreRequisite (Description) values('Minimum Five Years of Software Development Experience')
insert into PreRequisite (Description) values('Object Oriented Programming Experience')

insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(24, 5);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(24, 3);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(24, 4);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(24, 6);

select * from TrainingCourseDuration

select * from TrainingCourse

insert into TrainingCourseDuration (TrainingCourseId, DurationID) values(24, 1)
insert into TrainingCourseDuration (TrainingCourseId, DurationID) values(24, 8)
