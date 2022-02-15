using System.Collections.Generic;

namespace CSharp.Fundamentals.LINQ.SetOperator
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            //First check if both object reference are equal then return true
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }
            //If either one of the object refernce is null, return false
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }
            //Comparing all the properties one by one
            return x.ID == y.ID && x.Name == y.Name;
        }
        public int GetHashCode(Student obj)
        {
            //If obj is null then return 0
            if (obj == null)
            {
                return 0;
            }
            //Get the ID hash code value
            int IDHashCode = obj.ID.GetHashCode();
            //Get the string HashCode Value
            //Check for null refernece exception
            int NameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();
            return IDHashCode ^ NameHashCode;

        }
    }
}
