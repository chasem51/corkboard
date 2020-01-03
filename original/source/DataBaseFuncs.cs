#define DATABASEFUNCS

using System;
using System.Collections.Generic;

public class DataBase
{

    // Driver code 
    public static LinkedList<String> MakeMajors()
    {

        // Creating a LinkedList of Strings 
        var Majors = new LinkedList<String>();

        // Biomedical Engineering 
        Majors.AddLast("Biomedical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, ENG EK100, 0, CAS CH101, 4, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, CAS CH102, 4, ENG EK131, 2, ENG EK103, 3, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS WR150, 4, CAS MA226, 4, ENG BE209, 4, ENG EK301, 4, ENG EK381, 4, CAS BI315, 4, ENG BE403, 4, ENG BE403, 4, ENG BE491, 2, ENG EK424, 4, ENG BE 492, 2, ENG BE465, 2, ENG BE466, 4, end");
        Majors.AddLast("Electives, One Continua & Fields Elective, Two Suitable Professional Electives, One Engineering elective, Two Biomedical engineering electives, One Biomedical engineering design elective");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        //Computer Engineering

        Majors.AddLast("Computer Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK327, 4, CAS MA226, 4, ENG EC311, 4, ENG EK301, 4, ENG EK210, 2, ENG EC330, 4, ENG EK381, 4, ENG EC413, 4, CAS MA193, 2, ENG EC463, 4, ENG EC464, 4, end");
        Majors.AddLast("Electives, Two Core Electives, Two Computer Engineering Electives, One EE Breadth Elective, 3 Technical Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        // Mechaincal Engineering

        Majors.AddLast("Mechanical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG ME357, 2, CAS MA226, 4, ENG EC381, 4, ENG EK301, 4, ENG EK210, 2, ENG ME304, 4, ENG ME303, 4, ENG ME305, 4, ENG ME358, 2, ENG ME306, 4, ENG ME419, 4, ENG ME302, 4, ENG ME360, 4, ENG ME310, 4, ENG ME460, 4, ENG ME461, 4, end");
        Majors.AddLast("Electives, Four Advanced Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        // Electrical Engineering

        Majors.AddLast("Electrical Engineering");
        Majors.AddLast("Required, CAS MA123, 4, CAS CH 131, 4, ENG EK100, 0, ENG EK125, 4, CAS WR120, 4, CAS MA124, 4, CAS PY211, 4, ENG EK131, 2, ENG EK103, 3, CAS WR150, 4, CAS MA225, 4, CAS PY212, 4, ENG EK307, 4, ENG EK210, 2, CAS MA226, 4, CAS PY 313, 4, ENG EK301, 4, ENG EC455, 4, ENG EC401, 4, ENG EC311, 4, ENG EC311, 4, ENG EK381, 4, END EC 463, 4, ENG EC 464, 4, end");
        Majors.AddLast("Electives, One Electronics Elective, One Systems Elective, One Electrophysics Elective, One Computer Elective, Three Technical Electives");
        Majors.AddLast("Hub Credits, PIL, AE, HC, SI, IC, GCI, GCI, ER");

        Majors.AddLast("0");

        return Majors;
    }



    static public List<String> ReturnMajor()
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        var currentalias = Majors.First.Next;
        List<String> majorlist = new List<String>();
        /*
        do
        {
            if (current.ToString() == "Mechanical Engineering" || current.ToString() == "Electrical Engineering" || current.ToString() == "Computer Engineering" || current.ToString() == "Biomedical Engineering")
            {
                majorlist.Add(current.ToString());
            }
            current = currentalias;
            currentalias = currentalias.Next;
        } while ((currentalias) != null);
        */

        majorlist.Add("Mechanical Engineering");
        majorlist.Add("Elecrical Engineering");
        majorlist.Add("Computer Engineering");
        majorlist.Add("Biomedical Engineering");


        return majorlist;
    }

    static string coursestring;
    static public List<String> ReturnMajor_courses(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcourses = new List<String>();
        /*
       do
       {
           if (current.ToString() == userinput)
           {
               coursestring = current.ToString();
           }
           current = current.Next;
       } while ((current) != null);
       string[] coursearrayandcredit = coursestring.Split(',');
       for (int i = 1; i < coursearrayandcredit.Length; i = i+2)
       {
           majorcourses.Add(coursearrayandcredit[i]);
           majorcourseelectives.add("One Systems Elective")
            majorcourseelectives.add("One Electrophysics Elective");
            majorcourseelectives.add("One Computer Elective");
            majorcourseelectives.add("Three Technical Electives");
       }
       */

        if (userinput == "Biomedical Engineering")
        {
            majorcourses.Add("CAS MA123");
            majorcourses.Add("ENG EK100");
            majorcourses.Add("CAS CH101");
            majorcourses.Add("ENG EK125");
            majorcourses.Add("CAS WR120");
            majorcourses.Add("CAS MA124");
            majorcourses.Add("CAS PY211");
            majorcourses.Add("CAS CH102");
            majorcourses.Add("ENG EK131");
            majorcourses.Add("ENG EK103");
            majorcourses.Add("CAS MA225");
            majorcourses.Add("CAS PY212");
            majorcourses.Add("ENG EK307");
            majorcourses.Add("ENG EK210");
            majorcourses.Add("CAS WR150");
            majorcourses.Add("CAS MA226");
            majorcourses.Add("ENG BE209");
            majorcourses.Add("ENG EK301");
            majorcourses.Add("ENG EK381");
            majorcourses.Add("CAS BI315");
            majorcourses.Add("ENG BE403");
            majorcourses.Add("ENG BE403");
            majorcourses.Add("ENG BE491");
            majorcourses.Add("ENG EK424");
            majorcourses.Add("ENG BE492");
            majorcourses.Add("ENG BE465");
            majorcourses.Add("ENG BE466");
        }
        else if (userinput == "Computer Engineering")
        {
            majorcourses.Add("CAS MA123");
            majorcourses.Add("CAS CH131");
            majorcourses.Add("ENG EK100");
            majorcourses.Add("ENG EK125");
            majorcourses.Add("CAS WR120");
            majorcourses.Add("CAS MA124");
            majorcourses.Add("CAS PY211");
            majorcourses.Add("ENG EK131");
            majorcourses.Add("ENG EK103");
            majorcourses.Add("CAS WR150");
            majorcourses.Add("CAS MA225");
            majorcourses.Add("CAS PY212");
            majorcourses.Add("ENG EK307");
            majorcourses.Add("ENG EK327");
            majorcourses.Add("CAS MA226");
            majorcourses.Add("ENG EC311");
            majorcourses.Add("ENG EK301");
            majorcourses.Add("ENG EK210");
            majorcourses.Add("ENG EC330");
            majorcourses.Add("ENG EK381");
            majorcourses.Add("ENG EC413");
            majorcourses.Add("CAS MA193");
            majorcourses.Add("ENG EC463");
            majorcourses.Add("ENG EC464");


        }
        else if (userinput == "Mechanical Engineering")
        {
            majorcourses.Add("CAS MA123");
            majorcourses.Add("CAS CH131");
            majorcourses.Add("ENG EK100");
            majorcourses.Add("ENG EK125");
            majorcourses.Add("CAS WR120");
            majorcourses.Add("CAS MA124");
            majorcourses.Add("CAS PY211");
            majorcourses.Add("ENG EK131");
            majorcourses.Add("ENG EK103");
            majorcourses.Add("CAS WR150");
            majorcourses.Add("CAS MA225");
            majorcourses.Add("CAS PY212");
            majorcourses.Add("ENG EK307");
            majorcourses.Add("ENG ME357");
            majorcourses.Add("CAS MA226");
            majorcourses.Add("ENG EC381");
            majorcourses.Add("ENG EK301");
            majorcourses.Add("ENG EK210");
            majorcourses.Add("ENG ME304");
            majorcourses.Add("ENG ME303");
            majorcourses.Add("ENG ME305");
            majorcourses.Add("ENG ME358");
            majorcourses.Add("ENG ME306");
            majorcourses.Add("ENG ME419");
            majorcourses.Add("ENG ME302");
            majorcourses.Add("ENG ME360");
            majorcourses.Add("ENG ME310");
            majorcourses.Add("ENG ME460");
            majorcourses.Add("ENG ME461");

        }
        else if (userinput == "Electrical Engineering")
        {
            majorcourses.Add("CAS MA123");
            majorcourses.Add("CAS CH131");
            majorcourses.Add("ENG EK100");
            majorcourses.Add("ENG EK125");
            majorcourses.Add("CAS WR120");
            majorcourses.Add("CAS MA124");
            majorcourses.Add("CAS PY211");
            majorcourses.Add("ENG EK131");
            majorcourses.Add("ENG EK103");
            majorcourses.Add("CAS WR150");
            majorcourses.Add("CAS MA225");
            majorcourses.Add("CAS PY212");
            majorcourses.Add("ENG EK307");
            majorcourses.Add("ENG EK210");
            majorcourses.Add("CAS MA226");
            majorcourses.Add("CAS PY313");
            majorcourses.Add("ENG EK301");
            majorcourses.Add("ENG EC455");
            majorcourses.Add("ENG EC401");
            majorcourses.Add("ENG EC311");
            majorcourses.Add("ENG EK381");
            majorcourses.Add("ENG EC464");
        }

        return majorcourses;


    }

    static public List<String> ReturnMajor_coursecredits(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursecredits = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                coursestring = Majors.First.Next.ToString();
            }
            current = current.Next;
        } while ((current.ToString()) != "0");
        string[] coursearrayandcredit = coursestring.Split(',');
        for (int i = 2; i < coursearrayandcredit.Length; i = i + 2)
        {
            majorcoursecredits.Add(coursearrayandcredit[i]);
        }
        */

        if (userinput == "Biomedical Engineering")
        {
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("0");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("3");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
        }
        else if (userinput == "Computer Engineering")
        {

            majorcoursecredits.Add("4");
            majorcoursecredits.Add("0");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("3");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
        }
        else if (userinput == "Mechanical Engineering")
        {

            majorcoursecredits.Add("4");
            majorcoursecredits.Add("0");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("3");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
        }
        else if (userinput == "Electrical Engineering")
        {

            majorcoursecredits.Add("4");
            majorcoursecredits.Add("0");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("3");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("4");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("2");
            majorcoursecredits.Add("4");
        }

        return majorcoursecredits;

    }


    static string electivestring;
    static public List<String> ReturnMajor_electives(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcourseelectives = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                current =current.Next;
                electivestring = current.Next.ToString();
            }
            current = current.Next;
        } while ((current) != null);
        string[] electives = electivestring.Split(',');
        for (int i = 0; i < electives.Length; i++)
        {
            majorcourseelectives.Add(electives[i]);
        }
        */
        if (userinput == "Biomedical Engineering")
        {
            majorcourseelectives.Add("One Continua & Fields Elective");
            majorcourseelectives.Add("Two Suitable Professional Electives");
            majorcourseelectives.Add("One Engineering elective");
            majorcourseelectives.Add("Two Biomedical engineering electives");
            majorcourseelectives.Add("One Biomedical engineering design elective");
        }
        else if (userinput == "Computer Engineering")
        {
            majorcourseelectives.Add("Two Core Electives");
            majorcourseelectives.Add("Two Computer Engineering Electives");
            majorcourseelectives.Add("One EE Breadth Elective");
            majorcourseelectives.Add("Technical Electives");
        }
        else if (userinput == "Mechanical Engineering")
        {
            majorcourseelectives.Add("Four Advanced Electives");
        }
        else if (userinput == "Electrical Engineering")
        {
            majorcourseelectives.Add("One Systems Elective");
            majorcourseelectives.Add("One Electrophysics Elective");
            majorcourseelectives.Add("One Computer Elective");
            majorcourseelectives.Add("Three Technical Electives");
        }


        return majorcourseelectives;
    }


    static string hubstring;
    static public List<String> ReturnMajor_hub(string userinput)
    {
        LinkedList<String> Majors = MakeMajors();
        var current = Majors.First;
        List<String> majorcoursehubs = new List<String>();

        /*
        do
        {
            if (current.ToString() == userinput)
            {
                current = current.Next;
                current = current.Next;
                hubstring = current.Next.ToString();
            }
            current = current.Next;
        } while ((current = current.Next) != null);
        string[] hubs = hubstring.Split(',');
        for (int i = 0; i < hubs.Length; i++)
        {
            majorcoursehubs.Add(hubs[i]);
        }
        */
        majorcoursehubs.Add("PIL");
        majorcoursehubs.Add("AE");
        majorcoursehubs.Add("HC");
        majorcoursehubs.Add("SI");
        majorcoursehubs.Add("IC");
        majorcoursehubs.Add("GCI");
        majorcoursehubs.Add("GCI");
        majorcoursehubs.Add("ER");



        return majorcoursehubs;
    }

    string[] gradeletter = [ "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D", "F" ];
    double[] gradevalues = [4.0, 3.7, 3.3, 3.0, 2.7, 2.3, 2.0, 1.7, 1.0, 0.0];
    double gradevalue;
        
    public double gradeconverter(string grade1)
        {   
            for( int i = 0; i < 10; i++)
            {
                if(gradeletter[i] == grade1)
                {
                    return gradesvalue[i];
                }
            } 
        } 

    public void creditconverter(string[] creditsstrings, int num, List<int> creditslist)
        {   
            for( int i = 0; i < num; i++)
            {
                int temp = int.Parse(creditsstrings[i]);
                creditslist.Add(temp);
            }  
        }

    public double GetGPA(string numcourses, string[] grades, string[] credits)
    {
        
        List<double> studentgradevalues = new List<double>();
        List<int> creditsint = new List<int>();
    

        int numcoursesint = int.Parse(numcourses);

        creditconverter(credits, numcoursesint, creditsint);

        while(int i <= numcoursesint)
        {
            double temp = gradeconverter(grades[i])
            studentgradevalues.Add(temp);
        }

        double summation = 0;
        double creditssum = 0; 

        for(int i = 0; i < numcoursesint; i++)
        {
            summation += studentgradevalues[i] * creditsint[i];
            creditssum += creditsint[i];
        }

        return summation/creditssum;
    }
}
    