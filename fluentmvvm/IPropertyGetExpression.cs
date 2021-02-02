﻿// <auto-generated>
// This file is generated by a T4 template. Make changes directly in the .tt file.
// </auto-generated>
#nullable enable
using System;

namespace FluentMvvm
{
    /// <summary>
    ///     Provides methods that can be used to get the value of a property.
    /// </summary>
    internal interface IPropertyGetExpression
    {

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <typeparamref name="T" />.
        /// </exception>
        T Get<T>(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Boolean" />.
        /// </exception>
        Boolean GetBoolean(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Byte" />.
        /// </exception>
        Byte GetByte(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.SByte" />.
        /// </exception>
        SByte GetSByte(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Char" />.
        /// </exception>
        Char GetChar(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Decimal" />.
        /// </exception>
        Decimal GetDecimal(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Double" />.
        /// </exception>
        Double GetDouble(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Single" />.
        /// </exception>
        Single GetSingle(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int16" />.
        /// </exception>
        Int16 GetInt16(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt16" />.
        /// </exception>
        UInt16 GetUInt16(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int32" />.
        /// </exception>
        Int32 GetInt32(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt32" />.
        /// </exception>
        UInt32 GetUInt32(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int64" />.
        /// </exception>
        Int64 GetInt64(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt64" />.
        /// </exception>
        UInt64 GetUInt64(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.DateTime" />.
        /// </exception>
        DateTime GetDateTime(string propertyName = null);

        /// <summary>
        ///     Gets the value of the specified property.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns>
        ///     The value of the property.
        /// </returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.String" />.
        /// </exception>
        String GetString(string propertyName = null);

        
    }
}