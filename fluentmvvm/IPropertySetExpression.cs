﻿// <auto-generated>
// This file is generated by a T4 template. Make changes directly in the .tt file.
// </auto-generated>
#nullable enable
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FluentMvvm
{
    /// <summary>
    ///     Provides methods that can be used to set a property value.
    /// </summary>
    /// <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
    public interface IPropertySetExpression
    {
        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <typeparamref name="T" />.
        /// </exception>
        IDependencyExpression Set<T>(T value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Boolean" />.
        /// </exception>
        IDependencyExpression Set(Boolean value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Byte" />.
        /// </exception>
        IDependencyExpression Set(Byte value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.SByte" />.
        /// </exception>
        IDependencyExpression Set(SByte value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Char" />.
        /// </exception>
        IDependencyExpression Set(Char value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Decimal" />.
        /// </exception>
        IDependencyExpression Set(Decimal value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Double" />.
        /// </exception>
        IDependencyExpression Set(Double value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Single" />.
        /// </exception>
        IDependencyExpression Set(Single value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int16" />.
        /// </exception>
        IDependencyExpression Set(Int16 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt16" />.
        /// </exception>
        IDependencyExpression Set(UInt16 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int32" />.
        /// </exception>
        IDependencyExpression Set(Int32 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt32" />.
        /// </exception>
        IDependencyExpression Set(UInt32 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.Int64" />.
        /// </exception>
        IDependencyExpression Set(Int64 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.UInt64" />.
        /// </exception>
        IDependencyExpression Set(UInt64 value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.DateTime" />.
        /// </exception>
        IDependencyExpression Set(DateTime value, [CallerMemberName] string propertyName = "");

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        ///     there are no backing fields of type <see cref="System.String" />.
        /// </exception>
        IDependencyExpression Set(String value, [CallerMemberName] string propertyName = "");

        

        /// <summary>
        ///     Sets the value of the specified property to <paramref name="value" /> and raises a
        ///     <see cref="INotifyPropertyChanged.PropertyChanged" /> event if the new value was different from the old value.
        /// </summary>
        /// <param name="value">The value to set the property to.</param>
        /// <param name="oldValue">A reference to the old value of the property. This can be a field.</param>
        /// <param name="propertyName">
        ///     The name of the property. Filled in by the compiler automatically, do not specify explicitly.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">
        ///     no public writable instance property named <paramref name="propertyName" /> could be found -or- <paramref name="propertyName" /> is empty or consists only of white-space characters.
        /// </exception>
        IDependencyExpression Set<T>(T value, ref T oldValue, [CallerMemberName] string propertyName = "");
    }
}