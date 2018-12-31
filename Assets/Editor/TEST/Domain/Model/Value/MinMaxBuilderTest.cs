using Assets.Editor.TEST.Domain.Model.Mock;
using Assets.Src.Domain.Model.Value;
using NUnit.Framework;
using System;

namespace Assets.Editor.TEST.Domain.Model.Value
{
    /// <summary>
    /// <see cref="MinMax{TValue}"/>クラスのビルダーの動作テスト
    /// </summary>
    public static class MinMaxBuilderTest
    {
        [Test]
        public static void MinMaxBuildTest_値型_未設定でビルド()
        {
            var minmax = MinMax<int>.builder.Build();

            minmax.IsNotNull();

            minmax.min.Is(default);
            minmax.max.Is(default);
        }
        [Test]
        public static void MinMaxBuildTest_値型_最小を設定してビルド()
        {
            var min = 4;

            var minmax = MinMax<int>.builder.Min(min).Build();

            minmax.IsNotNull();

            minmax.min.Is(min);
            minmax.max.Is(default);
        }
        [Test]
        public static void MinMaxBuildTest_値型_最大を設定してビルド()
        {
            var max = 15;

            var minmax = MinMax<int>.builder.Max(max).Build();

            minmax.IsNotNull();

            minmax.min.Is(default);
            minmax.max.Is(max);
        }
        [Test]
        public static void MinMaxBuildTest_値型_最大最小を設定してビルド()
        {
            var min = 4;
            var max = 15;

            var minmax = MinMax<int>.builder.Min(min).Max(max).Build();

            minmax.IsNotNull();

            minmax.min.Is(min);
            minmax.max.Is(max);
        }
        [Test]
        public static void MinMaxBuildTest_値型_最大最小を同値に設定してビルド()
        {
            var number = 4;

            var minmax = MinMax<int>.builder.Min(number).Max(number).Build();

            minmax.IsNotNull();

            minmax.min.Is(number);
            minmax.max.Is(number);
        }
        [Test]
        public static void MinMaxBuildTest_値型_最小を最大より大きく設定してビルド()
        {
            var min = 48;
            var max = 15;

            var builder = MinMax<int>.builder.Min(min).Max(max);

            Assert.Throws<ArgumentOutOfRangeException>(() => builder.Build());
        }
        [Test]
        public static void MinMaxBuildTest_参照型_未設定でビルド()
        {
            var minmax = MinMax<ClassMock>.builder.Build();

            minmax.IsNotNull();

            minmax.min.IsNull();
            minmax.max.IsNull();
        }
        [Test]
        public static void MinMaxBuildTest_参照型_最小を設定してビルド()
        {
            var min = new ClassMock { text1 = "min", number = 4 };

            var minmax = MinMax<ClassMock>.builder.Min(min).Build();

            minmax.IsNotNull();

            minmax.min.IsSameReferenceAs(min);
            minmax.max.IsNull();
        }
        [Test]
        public static void MinMaxBuildTest_参照型_最大を設定してビルド()
        {
            var max = new ClassMock { text1 = "max", number = 15 };

            var minmax = MinMax<ClassMock>.builder.Max(max).Build();

            minmax.IsNotNull();

            minmax.min.IsNull();
            minmax.max.IsSameReferenceAs(max);
        }
        [Test]
        public static void MinMaxBuildTest_参照型_最大最小を設定してビルド()
        {
            var min = new ClassMock { text1 = "min", number = 4 };
            var max = new ClassMock { text1 = "max", number = 15 };

            var minmax = MinMax<ClassMock>.builder.Min(min).Max(max).Build();

            minmax.IsNotNull();

            minmax.min.IsSameReferenceAs(min);
            minmax.max.IsSameReferenceAs(max);
        }
        [Test]
        public static void MinMaxBuildTest_参照型_最大最小を同値に設定してビルド()
        {
            var classMock = new ClassMock { text1 = "min", number = 4 };
            
            var minmax = MinMax<ClassMock>.builder.Min(classMock).Max(classMock).Build();

            minmax.IsNotNull();

            minmax.min.IsSameReferenceAs(classMock);
            minmax.max.IsSameReferenceAs(classMock);
        }
        [Test]
        public static void MinMaxBuildTest_参照型_最小を最大より大きく設定してビルド()
        {
            var min = new ClassMock { text1 = "min", number = 15 };
            var max = new ClassMock { text1 = "max", number = 4 };

            var builder = MinMax<ClassMock>.builder.Min(min).Max(max);

            Assert.Throws<ArgumentOutOfRangeException>(() => builder.Build());
        }
    }
}
