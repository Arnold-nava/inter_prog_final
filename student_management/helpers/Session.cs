namespace student_management.Helpers
{
    public static class Session
    {
        public static int userId;
        public static int studentId;
        public static int teacherId;

        public static string username;
        public static string role;
        public static string fullName;

        public static string studentNumber;
        public static string teacherNumber;

        public static int classId;
        public static string className;
        public static string gradeLevel;
        public static string section;

        public static int subjectId;
        public static string subjectName;

        public static void Clear()
        {
            userId = 0;
            studentId = 0;
            teacherId = 0;

            username = "";
            role = "";
            fullName = "";

            studentNumber = "";
            teacherNumber = "";

            classId = 0;
            className = "";
            gradeLevel = "";
            section = "";

            subjectId = 0;
            subjectName = "";
        }
    }
}