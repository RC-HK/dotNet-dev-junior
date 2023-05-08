namespace InnerType;

public class Student
{
    private int _id;
    private String _name;
    private Department _department {  set; get; }

    public String DepartmentName()
    {
        return this._department.Name;
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Student(int id, String name, String departmentName)
    {
        Id = id;
        Name = name;
        _department = new Department(departmentName, 1,1);
    }

    private class Department
    {
        private int _id;
        private String _name;
        private int _advisorId;

        public Department(string name, int id, int advisorId)
        {
            Name = name;
            Id = id;
            AdvisorId = _advisorId;
        }


        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int AdvisorId
        {
            get => _advisorId;
            set => _advisorId = value;
        }
        
        
    }
}