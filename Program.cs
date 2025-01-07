class Program {
    static void Main(string[] args)
    {
        List<Member> members = new List<Member>
        {
        new Member("Engibar", 90, 1,  0, 0), //всичко под 0 е null
        new Member("Iliyca", 79, 2, -4 , -4),
        new Member("Bogdan",60, 3, 1, 2),
        new Member("Mariq",59, 4, 1, 2),
        new Member("Konstantin", 62, 5, -1, -1),
        new Member("Boqna",58, 6, 1, 2),
        new Member("Kamen",54, 7, 1, 2),
        new Member("Cecka", 60, 8 ,-2 ,-2),
        new Member("Mihail",30, 9, 7, 8),
        new Member("Cvetelina",31, 10, -3,-3),
        new Member("Svetoslav", 9, 11, 9, 10)
        };

        var Selection = members.Where(x => x.FatherId() ==1);
        foreach (var member in Selection) 
        {
            Console.WriteLine($"Id: {member.Id()}, Name: {member.Name()}");
        }
    }


    class Member
    {
        string name;
        int age;
        int id;
        int parentId;
        int parentId2;
        
        public Member(string name,int age,int id, int parentId, int parentId2)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.parentId = parentId;
        }
    public string Name() 
        {
            return name;
        }
        public int Age()
        {
            return age;
        }
        public int Id()
        {
            return id;
        }
        public int FatherId()
        {   
            return parentId;
        }
        public int MotherId()
        { 
            return parentId2;
        }
    }

}