namespace CreationPatternPractice
{
    public interface IMyCloneable<T> where T : class
    {
        T CloneThis();
    }
}
