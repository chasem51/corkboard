Clementine Productions

Team Members:

Chase Maivald: Technical Lead
Raunaq Zamal: Specification Lead
Paige Hartley: Interface Lead
Nafis Abeer: Project Lead

Team Mentor: Miguel Mark

Project General Description:

This project will be executed in the form of an app for current BU students. It is meant to help one plan future courses based on the classes they have taken and their desired graduating certificate. If the user is unsure of their desired certificate, the app would help choose a potential certificate. This app is useful for any student who has difficulty in course planning for their major. It is especially useful for those that would like to change their current major, or would like to complete a minor. Utilizing this app will allow students to layout courses until graduation without the stress of advisor appointments and generalized planning sheets. The app will provide major/minor certificates at BU ranked in order of degree completion. The user first inputs their desired major, and all relevant completed/planned courses to complete. Majors/minors with 0% completion are not listed. Based on the order of certificates, the user will know how attainable their degree is over time. The student can then use this information to layout the remainder of their time at BU into a custom calendar application view. This app will provide the insight of how many semesters/potential summer sessions are required for specific certificates. This application will serve as a preferable advising tool, as it removes every element of bias from a physical advisor. An advisor’s objective view of the students’ interests/abilities may sway their recommendations, but in most cases, the courses that a student will take is predominantly up to that students’ discretion. This may also lower the error from an advisor’s failure to remember all of a student’s potential options. In full, this will serve as a more robust advising platform to that available at BU, and could optimize the decision making in relation to one’s educational growth and post-graduation employment ability.

Project Technical Description: 

The control flow of this desktop application mostly follows the button clicks of a user. They select their major, all major/minor requirements that have been completed, and their desired number of semesters/summer semesters. The user can backtrace all inputs and change them if incorrect. Firstly, they specify their desired major(s)/minor(s), number of desired semesters, and they are guided through entries of any degree-specific courses. Then, they may navigate to a search for non-major classes such as Hub electives. The user may then enter any classes they completed/will complete that are not part of their selected major in a separate type of search. This search may find any course available at BU. For each of these search menus, the user’s search is added if it is found in the relevant input file. The first input file will be scraped for non-major major requirements. The second input file will be scraped for any course available at BU. Then, if the user would like to plan summer courses, they specify the time and number of summer semesters. They then search an input file for summer courses traditionally available at BU. Courses that have been taken, are in progress, or planned to be taken are differentiated by color and noted with their respective classification. Throughout the program, any major/minor that is partially completed is displayed, with the highest percentage completion at the top of the list. Finally, GPA may be input as well. GPA is displayed if known/entered, and its average is displayed by semester, year, and total cumulative. If unknown, GPA is preset to ?? in each individual course, semester, or year. If the user has a high enough GPA for cum laude, dean’s list, or Questrom Honors, this is listed. The user can enable a goal GPA view of the application, in which they set a goal GPA, and the average GPA required to attain the goal GPA is assigned per cumulative year and semester. 


Project Technology: 

C#
Python
Windows Presentation Foundation (WPF) framework
.NET core 3.0

GitHub Repository Link: https://github.com/chasem51/clementine

