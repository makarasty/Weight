#nullable enable
namespace Weight;

using Xunit;

public class WeightTests
{
	[Theory]
	[InlineData(5, ConsoleColor.Red, 3, 7, ConsoleColor.Green, 1, false)]
	[InlineData(5, ConsoleColor.Blue, 2, 5, ConsoleColor.Blue, 2, true)]
	public void EqualityOperator_ReturnsExpected(
		int m1, ConsoleColor c1, int s1, int m2, ConsoleColor c2, int s2, bool expected)
	{
		// Arrange 
		var w1 = new MyWeight { Mass = m1, Color = c1, Size = s1 };
		var w2 = new MyWeight { Mass = m2, Color = c2, Size = s2 };

		// Act
		var result = w1 == w2;

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void InequalityOperator_SameWeights_ReturnsFalse()
	{
		// Arrange
		var w1 = new MyWeight { Mass = 5, Color = ConsoleColor.Blue, Size = 2 };
		var w2 = new MyWeight { Mass = 5, Color = ConsoleColor.Blue, Size = 2 };

		// Act
		var result = w1 != w2;

		// Assert
		Assert.False(result);
	}

	[Theory]
	[InlineData(5, 7, false)]
	[InlineData(7, 5, true)]
	public void GreaterThanOperator_ReturnsExpected(int m1, int m2, bool expected)
	{
		// Arrange
		var w1 = new MyWeight { Mass = m1 };
		var w2 = new MyWeight { Mass = m2 };

		// Act
		var result = w1 > w2;

		// Assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData(5, 7, true)]
	[InlineData(7, 5, false)]
	public void LessThanOperator_ReturnsExpected(int m1, int m2, bool expected)
	{
		// Arrange
		var w1 = new MyWeight { Mass = m1 };
		var w2 = new MyWeight { Mass = m2 };

		// Act
		var result = w1 < w2;

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void GreaterThanOrEqualOperator_EqualMasses_ReturnsTrue()
	{
		// Arrange
		var w1 = new MyWeight { Mass = 5 };
		var w2 = new MyWeight { Mass = 5 };

		// Act
		var result = w1 >= w2;

		// Assert
		Assert.True(result);
	}

	[Fact]
	public void LessThanOrEqualOperator_EqualMasses_ReturnsTrue()
	{
		// Arrange
		var w1 = new MyWeight { Mass = 5 };
		var w2 = new MyWeight { Mass = 5 };

		// Act
		var result = w1 <= w2;

		// Assert
		Assert.True(result);
	}

	[Theory]
	[InlineData(5, ConsoleColor.Red, 3, 7, ConsoleColor.Green, 1, false)]
	[InlineData(5, ConsoleColor.Blue, 2, 5, ConsoleColor.Blue, 2, true)]
	public void Equals_ReturnsExpected(
		int m1, ConsoleColor c1, int s1, int m2, ConsoleColor c2, int s2, bool expected)
	{
		// Arrange
		var w1 = new MyWeight { Mass = m1, Color = c1, Size = s1 };
		var w2 = new MyWeight { Mass = m2, Color = c2, Size = s2 };

		// Act
		var result = w1.Equals(w2);

		// Assert
		Assert.Equal(expected, result);
	}

	[Fact]
	public void GetHashCode_EqualWeights_SameHashCode()
	{
		// Arrange
		var w1 = new MyWeight { Mass = 5, Color = ConsoleColor.Blue, Size = 2 };
		var w2 = new MyWeight { Mass = 5, Color = ConsoleColor.Blue, Size = 2 };

		// Act
		var hash1 = w1.GetHashCode();
		var hash2 = w2.GetHashCode();

		// Assert
		Assert.Equal(hash1, hash2);
	}

	[Theory]
	[InlineData(5, 7, -1)]
	[InlineData(7, 5, 1)]
	public void CompareTo_ReturnsExpected(int m1, int m2, int expected)
	{
		// Arrange
		var w1 = new MyWeight { Mass = m1 };
		var w2 = new MyWeight { Mass = m2 };

		// Act
		var result = w1.CompareTo(w2);

		// Assert
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData(3, 5, 1, 0, -1)]
	[InlineData(5, 3, 2, 0, 1)]
	[InlineData(1, 0, 5, 3, 1)]
	[InlineData(2, 0, 3, 5, 1)]
	public void Compare_ReturnsExpected(int s1, int s2, int m1, int m2, int expected)
	{
		// Arrange
		var w1 = new MyWeight { Size = s1, Mass = m1 };
		var w2 = new MyWeight { Size = s2, Mass = m2 };

		// Act
		var result = new MyWeight().Compare(w1, w2);

		// Assert
		Assert.Equal(expected, result);
	}
}