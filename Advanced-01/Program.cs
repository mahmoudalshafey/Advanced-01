
namespace Advanced_01
{
    internal class Program
    {
        #region Ques 1
        // A generic class has type parameters(like T) that are replaced by
        // real types when used. Benefits: compile-time type safety, no casting,
        // no boxing of value types, and one implementation reused for any type.
        #endregion

        #region Ques 2
        //public class Container<T>
        //{
        //    private List<T> items = new();

        //    public void Add(T item) => items.Add(item);

        //    public T Get(int index)
        //    {
        //        if (index < 0 || index >= items.Count)
        //            throw new ArgumentOutOfRangeException(nameof(index));
        //        return items[index];
        //    }

        //    public int Count => items.Count;
        //}
        #endregion

        #region Ques 3
        //public class Pair<TKey, TValue>
        //{
        //    public TKey Key { get; }
        //    public TValue Value { get; }

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }

        //    public override string ToString() => $"({Key}, {Value})";
        //}
        #endregion

        #region Ques 4
        // A generic method is a method declared with type parameters, allowing it to work with arguments of any specified type.

        //public static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        #region Ques 5

        //public static T FindMax<T>(T a, T b) where T : IComparable<T>
        //{
        //    return a.CompareTo(b) > 0 ? a : b;
        //}
        #endregion

        #region Ques 6
        // A generic interface allows contract definition for operations on strongly typed collections or services without specifying concrete types.

        //public interface IRepository<T> where T : class
        //{
        //    T? GetById(int id);
        //    IEnumerable<T> GetAll();
        //    void Add(T entity);
        //    void Update(T entity);
        //    void Delete(int id);
        //}
        #endregion

        #region Ques 7
        // The struct constraint specifies that the type argument must be a non-nullable value type.

        //public class StructWrapper<T> where T : struct
        //{
        //    public T Value { get; set; }
        //    public T? AsNullable => Value;   
        //}
        #endregion

        #region Ques 8
        // The class constraint specifies that the type argument must be a reference type.

        //public class ClassLogger<T> where T : class
        //{
        //    public void Log(T? item)
        //    {
        //        if (item == null)
        //        {
        //            Console.WriteLine("null");
        //            return;
        //        }
        //        Console.WriteLine(item.ToString());
        //    }
        //}
        #endregion

        #region Ques 9
        // The new() constraint requires the type argument to have a public parameterless constructor[cite: 1].

        //public class Factory<T> where T : new()
        //{
        //    public T Create() => new T();
        //}

        //public class Car
        //{
        //    public string Model { get; set; } = "Default";
        //}
        #endregion

        #region Ques 10
        // Interface constraint: T must implement the interface

        //public interface IPrintable
        //{
        //    void Print();
        //}

        //public class Printer<T> where T : IPrintable
        //{
        //    public void PrintAll(IEnumerable<T> items)
        //    {
        //        foreach (var item in items)
        //            item.Print();   // safe, T is IPrintable
        //    }
        //}

        //public class Invoice : IPrintable
        //{
        //    public void Print() => Console.WriteLine("Printing invoice...");
        //}

        #endregion

        #region Ques 11
        // Base class constraint: T must be, or derive from, the base class

        //public abstract class Entity
        //{
        //    public int Id { get; set; }
        //}

        //public class Product : Entity, IComparable<Product>
        //{
        //    public string Name { get; set; } = "";
        //    public decimal Price { get; set; }

        //    public int CompareTo(Product? other) =>
        //        other is null ? 1 : Price.CompareTo(other.Price);

        //    public override string ToString() => $"{Name} ({Price})";
        //}

        //public class EntityStore<T> where T : Entity
        //{
        //    private readonly Dictionary<int, T> _items = new();

        //    public void Save(T item) => _items[item.Id] = item;   
        //    public T? Find(int id) => _items.GetValueOrDefault(id);
        //}
        #endregion

        #region Ques 12
        // Multiple constraints
        // Order: class/struct, base class, interfaces, new() last.
        // Each type parameter gets its own where clause.

        //public class Repo<T> where T : Entity, IComparable<T>, new()
        //{
        //    public T CreateDefault() => new T();
        //}

        //public class Pairing<TKey, TValue>
        //    where TKey : struct, IComparable<TKey>
        //    where TValue : class, new()
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; } = new TValue();
        //}
        #endregion

        #region Ques 13
        // default(T) gives 0 for numbers, false for bool, null for
        // reference types, and a zeroed struct for custom structs.

        //public static class DefaultDemo
        //{
        //   public static T? GetOrDefault<T>(List<T> list, int index) =>
        //       index >= 0 && index < list.Count ? list[index] : default;
        //}
        #endregion

        #region Ques 14
        // SafeList<T> returns default when the index is invalid

        //public class SafeList<T>
        //{
        //    private readonly List<T> _items = new();

        //    public void Add(T item) => _items.Add(item);
        //    public int Count => _items.Count;

        //    public T? this[int index] =>
        //        index >= 0 && index < _items.Count ? _items[index] : default;
        //}
        #endregion

        #region Ques 15

        #endregion

        #region Ques 16

        #endregion

        #region Ques 17

        #endregion

        #region Ques 18

        #endregion

        #region Ques 19

        #endregion

        #region Ques 20

        #endregion
    }
}
