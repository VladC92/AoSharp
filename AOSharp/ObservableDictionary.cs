﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace AOSharp
{
    public class ObservableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public ObservableDictionary() : base() { }
        public ObservableDictionary(int capacity) : base(capacity) { }
        public ObservableDictionary(IEqualityComparer<TKey> comparer) : base(comparer) { }
        public ObservableDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary) { }
        public ObservableDictionary(int capacity, IEqualityComparer<TKey> comparer) : base(capacity, comparer) { }
        public ObservableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : base(dictionary, comparer) { }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public new TValue this[TKey key]
        {
            get => base[key];
            set
            {
                bool exist = base.TryGetValue(key, out TValue oldValue);
                var oldItem = new KeyValuePair<TKey, TValue>(key, oldValue);
                base[key] = value;
                var newItem = new KeyValuePair<TKey, TValue>(key, value);
                if (exist)
                {
                    this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem, base.Keys.ToList().IndexOf(key)));
                }
                else
                {
                    this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, newItem, base.Keys.ToList().IndexOf(key)));
                    this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
                }
            }
        }

        public new void Add(TKey key, TValue value)
        {
            if (!base.ContainsKey(key))
            {
                var item = new KeyValuePair<TKey, TValue>(key, value);
                base.Add(key, value);
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, base.Keys.ToList().IndexOf(key)));
                this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
            }
        }

        public new bool Remove(TKey key, TValue value) 
        {
            if (base.ContainsKey(key))
            {
                var item = new KeyValuePair<TKey, TValue>(key, value);
                int index = base.Keys.ToList().IndexOf(key);
                bool result = base.Remove(item.Key);
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
                return result;
            }
            return false;
        }

        public new bool Remove(TKey key)
        {
            if (base.TryGetValue(key, out TValue value))
            {
                var item = new KeyValuePair<TKey, TValue>(key, base[key]);
                bool result = base.Remove(key);
                return result;
            }
            return false;
        }

        public new void Clear()
        {
            base.Clear();
            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            this.OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, e);
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}
