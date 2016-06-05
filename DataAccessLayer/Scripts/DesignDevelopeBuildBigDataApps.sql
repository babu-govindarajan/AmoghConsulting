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

insert into Syllabus (Description) values ('Introduction to Ingest')
insert into Syllabus (Description) values ('Understanding Data Management tools namely, Sqoop, Flume, HCatalog, Kite SDK, Morhlines and Avro')

insert into Syllabus (Description) values ('Understanding HDFS')
insert into Syllabus (Description) values ('Under file formats, serialization and data compression in Hadoop')

insert into Syllabus (Description) values ('Understanding Apache Avro data serialization')
insert into Syllabus (Description) values ('Building Systems on top of the Hadoop using Kite SDK')
insert into Syllabus (Description) values ('Transferring bulk data using Apache Sqoop')
insert into Syllabus (Description) values ('Collecting, Aggregating, and Moving large amounts of streaming event data using Flume')
insert into Syllabus (Description) values ('Managing Apache Hadoop jobs using Oozie')
insert into Syllabus (Description) values ('Writing, Testing and Running MapReduce pipelines using Apache Crunch')
insert into Syllabus (Description) values ('Querying and Managing large datasets residing in distributed storage using Apache Hive')
insert into Syllabus (Description) values ('Querying data stored in HDFS or Apache HBase using Impala')

insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 170)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 171)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 172)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 173)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 174)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 175)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 176)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 177)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 178)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 179)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 180)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (25, 181)


select * from TrainingCourse

insert into TrainingCourse (TrainingSubjectID, StartDate, EndDate, Location) values(25, '2015-01-01', '2015-03-01', 'Bothell')


select * from PreRequisite

select * from TrainingSubjectPreRequisite

insert into PreRequisite (Description) values('Minimum Five Years of Software Development Experience')
insert into PreRequisite (Description) values('Object Oriented Programming Experience')

insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(25, 5);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(25, 3);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(25, 4);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(25, 6);

select * from TrainingCourseDuration

select * from TrainingCourse

select * from Duration


insert into TrainingCourseDuration (TrainingCourseId, DurationID) values(25, 3)
insert into TrainingCourseDuration (TrainingCourseId, DurationID) values(25, 6)
