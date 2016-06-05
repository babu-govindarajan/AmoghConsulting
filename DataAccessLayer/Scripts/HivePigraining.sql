insert into Syllabus (Description) values ('Introduction to Spark')
insert into Syllabus (Description) values ('Interactive Analysis with the Spark Shell')
insert into Syllabus (Description) values ('Working with Resilient Distributed Data set')
insert into Syllabus (Description) values ('Introduction to HDFS')
insert into Syllabus (Description) values ('Running Spark on a cluster')
insert into Syllabus (Description) values ('Parallel Programming with Spark')
insert into Syllabus (Description) values ('Caching and Persistence')
insert into Syllabus (Description) values ('Writing Spark Applications')
insert into Syllabus (Description) values ('Unit Testing Spark Applications')
insert into Syllabus (Description) values ('Spark Streaming')
insert into Syllabus (Description) values ('Common Patterns in Spark Programming')
insert into Syllabus (Description) values ('Tuning Spark Performance')
insert into Syllabus (Description) values ('Spark, Hadoop and the Enterprise Data Center')
insert into Syllabus (Description) values ('Machine Learning Library (MLlib)')
insert into Syllabus (Description) values ('GraphX Programming')
insert into Syllabus (Description) values ('Bagel Programming')

select * from Syllabus

insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 196)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 197)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 198)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 199)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 200)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 201)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 202)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 203)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 204)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 205)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 206)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 207)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 208)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 209)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 210)
insert into TrainingSubjectSyllabus (TrainingSubjectId, SyllabusID) values (27, 211)

insert into TrainingCourse (TrainingSubjectID, StartDate, EndDate, Location) values(27, '2015-01-01', '2015-03-01', 'Bothell')


insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(27, 5);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(27, 3);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(27, 4);
insert into TrainingSubjectPreRequisite (TrainingSubjectID, PreRequisiteID) values(27, 6);
