// Copyright (c) 2017 Andrey Ushkalov

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Windows;
using NUnit.Framework;

namespace ResourceProvider.Tests
{
    /// <summary>
    /// ����� ��� �������� ����������� �������� ��������
    /// </summary>
    [TestFixture]
    public class TestDictionaryTests
    {
        /// <summary>
        /// �������� ������� ��������
        /// </summary>
        /// <param name="path">���� � �������</param>
        private static ResourceDictionary GetResourceDictionary(string path)
        {
            return new ResourceDictionary { Source = new Uri(path) };
        }

        [Test]
        public void TestDictionary1Exists()
        {
            GetResourceDictionary(ResourceProviderTestsConstants.Dictionary1.Path);
        }

        [Test]
        public void TestDictionary1Content()
        {
            var testDictionary = GetResourceDictionary(ResourceProviderTestsConstants.Dictionary1.Path);
            Assert.Contains(ResourceProviderTestsConstants.DictionaryKey1, testDictionary.Keys);
            Assert.AreEqual(ResourceProviderTestsConstants.Dictionary1Value1, testDictionary[ResourceProviderTestsConstants.DictionaryKey1]);
            Assert.That(testDictionary.Keys, Has.No.Contain(ResourceProviderTestsConstants.DictionaryKey2));
        }

        [Test]
        public void TestDictionary2Exists()
        {
            GetResourceDictionary(ResourceProviderTestsConstants.Dictionary2.Path);
        }

        [Test]
        public void TestDictionary2Content()
        {
            var testDictionary = GetResourceDictionary(ResourceProviderTestsConstants.Dictionary2.Path);
            Assert.Contains(ResourceProviderTestsConstants.DictionaryKey1, testDictionary.Keys);
            Assert.AreEqual(ResourceProviderTestsConstants.Dictionary2Value1, testDictionary[ResourceProviderTestsConstants.DictionaryKey1]);
            Assert.Contains(ResourceProviderTestsConstants.DictionaryKey2, testDictionary.Keys);
            Assert.AreEqual(ResourceProviderTestsConstants.Dictionary2Value2, testDictionary[ResourceProviderTestsConstants.DictionaryKey2]);
        }
    }
}