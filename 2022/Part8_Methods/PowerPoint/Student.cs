namespace Part8_Methods.PowerPoint
{
    class Student
    {
        private string sNumber;

        public string getSNumber()
        {
            return this.sNumber;
        }

        public void setSNumber(string sNumber)
        {
            this.sNumber = sNumber;
        }

        public void blah()
        {
            Student student = new Student();
            student.setSNumber("S00712345");
        }
    }
}
