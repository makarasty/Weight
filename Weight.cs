namespace Weight;

using System;

public class MyWeight : IComparable<MyWeight>, IComparer<MyWeight>
{
	public int Mass { get; set; }
	public ConsoleColor Color { get; set; }
	public int Size { get; set; }

	public static bool operator ==(MyWeight? lhs, MyWeight? rhs)
	{
		if (lhs is null && rhs is null) return true;
		if (lhs is null || rhs is null) return false;
		return lhs.Equals(rhs);
	}

	public static bool operator !=(MyWeight? lhs, MyWeight? rhs) => !(lhs == rhs);

	public static bool operator >(MyWeight? lhs, MyWeight? rhs)
	{
		if (lhs is null) return false;
		if (rhs is null) return true;
		return lhs.CompareTo(rhs) > 0;
	}

	public static bool operator <(MyWeight? lhs, MyWeight? rhs)
	{
		if (lhs is null) return true;
		if (rhs is null) return false;
		return lhs.CompareTo(rhs) < 0;
	}

	public static bool operator >=(MyWeight? lhs, MyWeight? rhs)
	{
		if (lhs is null) return false;
		if (rhs is null) return true;
		return lhs.CompareTo(rhs) >= 0;
	}

	public static bool operator <=(MyWeight? lhs, MyWeight? rhs)
	{
		if (lhs is null) return true;
		if (rhs is null) return false;
		return lhs.CompareTo(rhs) <= 0;
	}

	public override bool Equals(object? obj)
	{
		return Equals(obj as MyWeight);
	}

	public bool Equals(MyWeight? other)
	{
		return other != null && Mass == other.Mass && Color == other.Color && Size == other.Size;
	}

	public override int GetHashCode()
	{
		// ~(=^‥^)ノ
		return HashCode.Combine(Mass, (int)Color, Size);
	}

	public int CompareTo(MyWeight? other)
	{
		if (other == null) throw new ArgumentNullException(nameof(other));

		return Mass.CompareTo(other.Mass);
	}

	public int Compare(MyWeight? x, MyWeight? y)
	{
		if (x is null && y is null) return 0;
		if (x is null) return -1;
		if (y is null) return 1;

		int sizeComparison = x.Size.CompareTo(y.Size);
		if (sizeComparison != 0) return sizeComparison;

		return x.Mass.CompareTo(y.Mass);
	}
}