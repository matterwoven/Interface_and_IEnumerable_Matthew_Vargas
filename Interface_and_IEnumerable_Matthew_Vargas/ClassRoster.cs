using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface_and_IEnumerable_Matthew_Vargas
{
    internal class ClassRoster : IEnumerable
    {
        int[] arr;

        List<Student> _classList;
        public ClassRoster() 
        {
            _classList = new List<Student>();
        }

        public List<Student> ClassList { get => _classList; }

        public void AddStudent(Student student) 
        { 
            _classList.Add(student); 
        }

        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade) 
        {
            _classList.Add(new Student(firstName, lastName, csiGrade, genEdGrade));
        }

        ////////////////////////////////////////////////////////////////////////////////////////

        // IEnumerable - How to loop
        // IEnumerator - How to work through a list
        public IEnumerator GetEnumerator() 
        {
            return new ClassRosterEnumerator(ref _classList);
        }

        //Internal class created to work with GetEnumerator
        private class ClassRosterEnumerator() : IEnumerator
        {
            int index = -1;
            List<Student> students;
            public ClassRosterEnumerator(ref List<Student> studentList) //second issue here
            {
                students = studentList;
            }

            public object Current => students[index];
            public bool MoveNext()
            { 
                index++;

                if(index >= students.Count) 
                {
                    return false;
                }
                else
                { 
                    return true;
                }
            }
            public void Reset()
            { index = -1; }
        }
    }
    //Below is included so the entire code doesn't go red regarding IEnumerable
    internal interface IEnumerator
    {
    }

    internal interface IEnumerable
    {
    }
}
