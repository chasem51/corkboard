#define DBSESSIONTEST

using System;



public class DBCourse
{
    public String CourseName;
    public float CourseCredits;

    public DBCourse()
    {
        CourseName = "";
        CourseCredits = 0;
    }

}

public class DBSchool
{
    public String SchoolName;
    public int NumCourses;
    public DBCourse[] Courses;

    public DBSchool()
    {
        SchoolName = "";
        NumCourses = 0;
    }

}


public class DBUserCourse
{
    public DBCourse Course;
    public enum DBYear
    {
        DBYEAR_1,  //remember year 1 has the value 0
        DBYEAR_2,
        DBYEAR_3,
        DBYEAR_4
    };

    public DBYear Year;
}

public class DatabaseSession
{
    public enum DBSessionStatus
    {
        DBSESSIONSTATUS_VOID,  //basic so that the GUI can get status info
        DBSESSIONSTATUS_OPEN,
        DBSESSIONSTATUS_CLOSED,
        DBSESSIONSTATUS_ERROR
    }



    public DBSessionStatus SessionStatus;
    public String UserID;

    public int NumSchools;
    public DBSchool Schools; //this should be a linked list in the final implementation so it can vary in size.

    public DBUserCourse[] UserCourses;


    public DatabaseSession()
    {
        UserID = "";
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_VOID;
    }

    public void StartSession(String UserIDForSession)
    {

#if DBSESSIONTEST
        //hand initialising the database so you have stuff to work with
        UserID = UserIDForSession;
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_OPEN;

        //basic initialising
        Schools.SchoolName = "PAIGE CODING";
        Schools.NumCourses = 3;
        Schools.Courses = new DBCourse[3];

        Schools.Courses[0].CourseName = "C#";
        Schools.Courses[0].CourseCredits = 5;
        Schools.Courses[1].CourseName = "C++";
        Schools.Courses[1].CourseCredits = 11;
        Schools.Courses[2].CourseName = "C";
        Schools.Courses[2].CourseCredits = 22;

        UserCourses = new DBUserCourse[5];
        UserCourses[0].Course = Schools.Courses[0];
        UserCourses[0].Year = DBUserCourse.DBYear.DBYEAR_1;
        UserCourses[1].Course = Schools.Courses[0];
        UserCourses[1].Year = DBUserCourse.DBYear.DBYEAR_2;
        UserCourses[2].Course = Schools.Courses[0];
        UserCourses[2].Year = DBUserCourse.DBYear.DBYEAR_3;
        UserCourses[3].Course = Schools.Courses[2];
        UserCourses[3].Year = DBUserCourse.DBYear.DBYEAR_1;
        UserCourses[4].Course = Schools.Courses[1];
        UserCourses[4].Year = DBUserCourse.DBYear.DBYEAR_4;

#else

        // typically this is where you would run database access for the user.

#endif
    }

    public void StartSession(String UserIDForSession)
    {

#if DBSESSIONTEST
        UserID = UserIDForSession;
        SessionStatus = DBSessionStatus.DBSESSIONSTATUS_OPEN;
#else
        // typically this is where you would run database access for the user

#endif
    }

    public void EndSession()
    {
    }

    public void AddUserCourse() { } //will take course id, school, year, etc to add class - error check here for credit exceeding and duplicate courses & update interface
    public void RemoveUserCourse() { } 
}