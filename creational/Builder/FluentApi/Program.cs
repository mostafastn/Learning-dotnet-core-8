// See https://aka.ms/new-console-template for more information
using FluentApi.Builder.Dtos;
using FluentApi.Builder.Implementations;

Console.WriteLine("Hello, World!");

var memberBuilder = new MemberBuilder();

var ahmed =
    memberBuilder
        .New
        .WithName("Ahmed")
        .WithAge(36)
        .AsTeacher
        .Teaching(new Subject("Software Engineering"))
        .WithSchedule(
            new Schedule
            (
                new DateTime(2021, 11, 20),
                new DateTime(2021, 12, 20)
            ), new Schedule
            (
                new DateTime(2022, 1, 5),
                new DateTime(2021, 3, 5)
            ))
        .Build();

var subjectsToStudy = new Subject[]
{
                new Subject("Software Engineering"),
                new Subject("Physics")
};

var mohamed =
    memberBuilder
        .New
        .WithAge(15)
        .WithName("Mohamed")
        .AsStudent
        .Studying(subjectsToStudy)
        .WithSchedule
        (
            new SubjectSchedule
            (
                subjectsToStudy[0],
                new Schedule
                (
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 12, 20)
                )
            ),
            new SubjectSchedule
            (
                subjectsToStudy[1],
                new Schedule
                (
                    new DateTime(2021, 11, 20),
                    new DateTime(2021, 12, 20)
                )
            )
        )
        .Build();
