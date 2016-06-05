select * from TrainingSubject

insert into Syllabus (Description) values ('Introduction Big Data')
insert into Syllabus (Description) values ('Introduction to Hadoop')
insert into Syllabus (Description) values ('Introduction to HDFS')
insert into Syllabus (Description) values ('Introduction to MapReduce')
insert into Syllabus (Description) values ('Introduction to Hive and Pig')
insert into Syllabus (Description) values ('Plan for Hadoop cluster hardware and software')
insert into Syllabus (Description) values ('Deploying Hadoop cluster')
insert into Syllabus (Description) values ('Populating HDFS from External Source')
insert into Syllabus (Description) values ('Installing Pig, Hive and Impala')
insert into Syllabus (Description) values ('Deploying Hadoop clients')
insert into Syllabus (Description) values ('Hadoop security')
insert into Syllabus (Description) values ('Monitoring, Troubleshooting and Optimizing Hadoop cluster')

select * from Syllabus

insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 212)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 213)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 214)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 215)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 216)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 217)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 218)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 219)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 220)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 221)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 222)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (28, 223)

insert into TrainingCourse (TrainingSubjectID, StartDate, EndDate, Location) values(28, '2015-01-01', '2015-03-01', 'Bothell')


insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(28, 5);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(28, 3);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(28, 4);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(28, 6);
