public class MathsAssignment : Assignment
    {

        //declaring variables

        private string _textBookSection;
        private string _problems;
        public MathsAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
            {

                // setting variables
                _textBookSection = textBookSection;
                _problems = problems;
            }

        public string GetHomeworkList()
            {
                return $"Section {_textBookSection} Problems {_problems}";
            }
    }