namespace Defense
{
  class DefenseException : System.Exception
  {
    public DefenseException()
    {
    }

    public DefenseException(string message) : base(message)
    {
    }
  }

  class OutOfBoundsException : DefenseException
  {
    public OutOfBoundsException()
    {
    }

    public OutOfBoundsException(string message) : base(message)
    {
    }
  }
}