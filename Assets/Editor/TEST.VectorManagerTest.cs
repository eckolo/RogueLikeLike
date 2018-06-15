using Assets.Src.Domains.Service;
using NUnit.Framework;
using UnityEngine;
using static UnityEngine.TextAnchor;

public static partial class TEST
{
    /// <summary>
    /// <see cref="VectorManager"/>クラスのテスト
    /// </summary>
    public static class VectorManagerTest
    {
        [Test]
        public static void Max()
        {
            var bigVector = new Vector2(5, 5);
            var smallVector = new Vector2(3, 4);

            Assert.AreEqual(VectorManager.Max(smallVector, bigVector), new Vector2(5, 5));
        }
        [Test]
        public static void Max2()
        {
            var vector = new Vector2(3, 4);
            var smallScalar = 4f;
            var bigScalar = 10f;

            Assert.AreEqual(VectorManager.Max(vector, smallScalar), new Vector2(3, 4));
            Assert.AreEqual(VectorManager.Max(vector, bigScalar), new Vector2(6, 8));
        }
        [Test]
        public static void Min()
        {
            var bigVector = new Vector2(5, 5);
            var smallVector = new Vector2(3, 4);

            Assert.AreEqual(VectorManager.Min(smallVector, bigVector), new Vector2(3, 4));
        }
        [Test]
        public static void Min2()
        {
            var vector = new Vector2(6, 8);
            var smallScalar = 5f;
            var bigScalar = 12f;

            Assert.AreEqual(VectorManager.Min(vector, smallScalar), new Vector2(3, 4));
            Assert.AreEqual(VectorManager.Min(vector, bigScalar), new Vector2(6, 8));
        }
        [Test]
        public static void Abs()
        {
            var vector = new Vector2(-3, -4);

            Assert.AreEqual(VectorManager.Abs(vector), new Vector2(3, 4));
        }
        [Test]
        public static void Correct()
        {
            var vector1 = new Vector2(3, 4);
            var vector2 = new Vector2(5, 5);

            Assert.AreEqual(VectorManager.Correct(vector1, vector2), new Vector2(4, 4.5f));
            Assert.AreEqual(VectorManager.Correct(vector1, vector2, 1), new Vector2(3, 4));
            Assert.AreEqual(VectorManager.Correct(vector1, vector2, 0), new Vector2(5, 5));
        }
        [Test]
        public static void Scaling()
        {
            var vector1 = new Vector2(3, 4);
            var vector2 = new Vector2(5, 5);

            Assert.AreEqual(VectorManager.Scaling(vector1, vector2), new Vector2(15, 20));
        }
        [Test]
        public static void Scaling2()
        {
            var vector = new Vector2(3, 4);
            var scalar1 = 3f;
            var scalar2 = 7f;

            Assert.AreEqual(VectorManager.Scaling(vector, scalar1, scalar2), new Vector2(9, 28));
        }
        [Test]
        public static void Rescaling()
        {
            var vector1 = new Vector2(3, 4);
            var vector2 = new Vector2(5, 5);

            Assert.AreEqual(VectorManager.Rescaling(vector1, vector2), new Vector2(0.6f, 0.8f));
        }
        [Test]
        public static void Rescaling2()
        {
            var vector = new Vector2(3, 4);
            var scalar1 = 3f;
            var scalar2 = 10f;

            Assert.AreEqual(VectorManager.Rescaling(vector, scalar1, scalar2), new Vector2(1, 0.4f));
        }
        [Test]
        public static void Rotate()
        {
            var vector1 = new Vector2(3, 4);
            var pivot1 = new Vector2(2, 5);
            var pivot2 = new Vector2(-4, 0);
            var angle1 = 90;
            var angle2 = -90;

            //どうしても有効桁数下2桁あたりで検算側に誤差が出るため手動で丸める
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot1, angle1).x * 1000) / 1000, 3);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot1, angle1).y * 1000) / 1000, 6);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot1, angle2).x * 1000) / 1000, 1);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot1, angle2).y * 1000) / 1000, 4);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot2, angle1).x * 1000) / 1000, -8);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot2, angle1).y * 1000) / 1000, 7);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot2, angle2).x * 1000) / 1000, 0);
            Assert.AreEqual(Mathf.Round(VectorManager.Rotate(vector1, pivot2, angle2).y * 1000) / 1000, -7);
        }
        [Test]
        public static void ToVector1()
        {
            var vector = new Vector2(3, 4);
            var scalar = 3f;

            Assert.AreEqual(VectorManager.ToVector(vector), new Vector2(0.6f, 0.8f));
            Assert.AreEqual(VectorManager.ToVector(vector, scalar), new Vector2(1.8f, 2.4f));
            Assert.AreEqual(VectorManager.ToVector(Vector2.zero, scalar), Vector2.zero);
        }
        [Test]
        public static void ToVector2()
        {
            var vector1 = new Vector2(3, 4);
            var vector2 = new Vector2(5, 12);

            Assert.AreEqual(VectorManager.ToVector(vector1, vector2), new Vector2(7.8f, 10.4f));
        }
        [Test]
        public static void ToVector3()
        {
            var rotation = Quaternion.AngleAxis(60, Vector3.forward);
            var scalar = 3f;

            Assert.AreEqual(VectorManager.ToVector(rotation), new Vector2(0.5f, 0.5f * Mathf.Sqrt(3)));
            Assert.AreEqual(VectorManager.ToVector(rotation, scalar), new Vector2(1.5f, 1.5f * Mathf.Sqrt(3)));
        }
        [Test]
        public static void ToVector4()
        {
            var angle = 60f;
            var scalar = 3f;

            Assert.AreEqual(VectorManager.ToVector(angle), new Vector2(0.5f, 0.5f * Mathf.Sqrt(3)));
            Assert.AreEqual(VectorManager.ToVector(angle, scalar), new Vector2(1.5f, 1.5f * Mathf.Sqrt(3)));
        }
        [Test]
        public static void ToVector5()
        {
            var angle = 60f;
            var vector = new Vector2(3, 4);

            Assert.AreEqual(VectorManager.ToVector(angle, vector), new Vector2(2.5f, 2.5f * Mathf.Sqrt(3)));
        }
        [Test]
        public static void Invert()
        {
            var vector1 = new Vector2(3, 4);
            var vector2 = new Vector2(-4, 5);
            var vector3 = new Vector2(0, 34);

            Assert.AreEqual(VectorManager.Invert(vector1), new Vector2(-3, 4));
            Assert.AreEqual(VectorManager.Invert(vector2), new Vector2(4, 5));
            Assert.AreEqual(VectorManager.Invert(vector3), new Vector2(0, 34));
        }
        [Test]
        public static void LinearizationTest()
        {
            Assert.Inconclusive();
        }
        [Test]
        public static void Within()
        {
            var vector1 = new Vector2(-2, -4);
            var vector2 = new Vector2(3, -4);
            var vector3 = new Vector2(8, -4);
            var vector4 = new Vector2(-2, 7);
            var vector5 = new Vector2(3, 7);
            var vector6 = new Vector2(8, 7);
            var vector7 = new Vector2(-2, 18);
            var vector8 = new Vector2(3, 18);
            var vector9 = new Vector2(8, 18);
            var underLeft = new Vector2(-1, -2);
            var upperRight = new Vector2(5, 12);

            Assert.AreEqual(VectorManager.Within(vector1, underLeft, upperRight), new Vector2(-1, -2));
            Assert.AreEqual(VectorManager.Within(vector2, underLeft, upperRight), new Vector2(3, -2));
            Assert.AreEqual(VectorManager.Within(vector3, underLeft, upperRight), new Vector2(5, -2));
            Assert.AreEqual(VectorManager.Within(vector4, underLeft, upperRight), new Vector2(-1, 7));
            Assert.AreEqual(VectorManager.Within(vector5, underLeft, upperRight), new Vector2(3, 7));
            Assert.AreEqual(VectorManager.Within(vector6, underLeft, upperRight), new Vector2(5, 7));
            Assert.AreEqual(VectorManager.Within(vector7, underLeft, upperRight), new Vector2(-1, 12));
            Assert.AreEqual(VectorManager.Within(vector8, underLeft, upperRight), new Vector2(3, 12));
            Assert.AreEqual(VectorManager.Within(vector9, underLeft, upperRight), new Vector2(5, 12));
        }
        [Test]
        public static void GetAxis()
        {
            Assert.AreEqual(VectorManager.GetAxis(LowerLeft), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight), new Vector2(1, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter), new Vector2(0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight), new Vector2(1, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft), new Vector2(0, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter), new Vector2(0.5f, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight), new Vector2(1, 1));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, LowerLeft), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, LowerLeft), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, LowerLeft), new Vector2(1, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, LowerLeft), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, LowerLeft), new Vector2(0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, LowerLeft), new Vector2(1, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, LowerLeft), new Vector2(0, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, LowerLeft), new Vector2(0.5f, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, LowerLeft), new Vector2(1, 1));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, LowerCenter), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, LowerCenter), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, LowerCenter), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, LowerCenter), new Vector2(-0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, LowerCenter), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, LowerCenter), new Vector2(0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, LowerCenter), new Vector2(-0.5f, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, LowerCenter), new Vector2(0, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, LowerCenter), new Vector2(0.5f, 1));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, LowerRight), new Vector2(-1, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, LowerRight), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, LowerRight), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, LowerRight), new Vector2(-1, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, LowerRight), new Vector2(-0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, LowerRight), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, LowerRight), new Vector2(-1, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, LowerRight), new Vector2(-0.5f, 1));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, LowerRight), new Vector2(0, 1));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, MiddleLeft), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, MiddleLeft), new Vector2(0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, MiddleLeft), new Vector2(1, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, MiddleLeft), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, MiddleLeft), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, MiddleLeft), new Vector2(1, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, MiddleLeft), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, MiddleLeft), new Vector2(0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, MiddleLeft), new Vector2(1, 0.5f));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, MiddleCenter), new Vector2(-0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, MiddleCenter), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, MiddleCenter), new Vector2(0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, MiddleCenter), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, MiddleCenter), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, MiddleCenter), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, MiddleCenter), new Vector2(-0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, MiddleCenter), new Vector2(0, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, MiddleCenter), new Vector2(0.5f, 0.5f));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, MiddleRight), new Vector2(-1, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, MiddleRight), new Vector2(-0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, MiddleRight), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, MiddleRight), new Vector2(-1, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, MiddleRight), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, MiddleRight), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, MiddleRight), new Vector2(-1, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, MiddleRight), new Vector2(-0.5f, 0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, MiddleRight), new Vector2(0, 0.5f));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, UpperLeft), new Vector2(0, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, UpperLeft), new Vector2(0.5f, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, UpperLeft), new Vector2(1, -1));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, UpperLeft), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, UpperLeft), new Vector2(0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, UpperLeft), new Vector2(1, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, UpperLeft), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, UpperLeft), new Vector2(0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, UpperLeft), new Vector2(1, 0));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, UpperCenter), new Vector2(-0.5f, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, UpperCenter), new Vector2(0, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, UpperCenter), new Vector2(0.5f, -1));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, UpperCenter), new Vector2(-0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, UpperCenter), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, UpperCenter), new Vector2(0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, UpperCenter), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, UpperCenter), new Vector2(0, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, UpperCenter), new Vector2(0.5f, 0));

            Assert.AreEqual(VectorManager.GetAxis(LowerLeft, UpperRight), new Vector2(-1, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerCenter, UpperRight), new Vector2(-0.5f, -1));
            Assert.AreEqual(VectorManager.GetAxis(LowerRight, UpperRight), new Vector2(0, -1));
            Assert.AreEqual(VectorManager.GetAxis(MiddleLeft, UpperRight), new Vector2(-1, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleCenter, UpperRight), new Vector2(-0.5f, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(MiddleRight, UpperRight), new Vector2(0, -0.5f));
            Assert.AreEqual(VectorManager.GetAxis(UpperLeft, UpperRight), new Vector2(-1, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperCenter, UpperRight), new Vector2(-0.5f, 0));
            Assert.AreEqual(VectorManager.GetAxis(UpperRight, UpperRight), new Vector2(0, 0));
        }
        [Test]
        public static void Log1()
        {
            var vector1 = Vector2.one.normalized * (Mathf.Exp(11.3f) - 1);
            var vector2 = new Vector2(-Mathf.Exp(26.43f) + 1, 0);

            Assert.AreEqual(vector1.Log().magnitude, 11.3f);
            Assert.AreEqual(vector1.Log().normalized, Vector2.one.normalized);
            Assert.AreEqual(vector2.Log(), new Vector2(-26.43f, 0));
        }
        [Test]
        public static void Log2()
        {
            var vector1 = Vector2.one.normalized * (Mathf.Pow(2.6f, 11.3f) - 1);
            var vector2 = new Vector2(-Mathf.Pow(4.63f, 26.43f) + 1, 0);

            Assert.AreEqual(vector1.Log(2.6f), Vector2.one.normalized * 11.3f);
            Assert.AreEqual(vector2.Log(4.63f), new Vector2(-26.43f, 0));
        }
        [Test]
        public static void EasingElliptical()
        {
            var destination = new Vector2(6, 9);
            var now = 60f;
            var max = 90f;

            Assert.AreEqual(VectorManager.EasingV.Elliptical(destination, now, max, true).y, 4.5f * Mathf.Sqrt(3));
            Assert.AreEqual(VectorManager.EasingV.Elliptical(destination, now, max, false).x, 3 * Mathf.Sqrt(3));
        }
        [Test]
        public static void EasingElliptical2()
        {
            var start = new Vector2(-2, -3);
            var destination = new Vector2(4, 6);
            var now = 60f;
            var max = 90f;

            Assert.AreEqual(VectorManager.EasingV.Elliptical(start, destination, now, max, true).y, 4.5f * Mathf.Sqrt(3) - 3);
            Assert.AreEqual(VectorManager.EasingV.Elliptical(start, destination, now, max, false).x, 3 * Mathf.Sqrt(3) - 2);
        }
    }
}
