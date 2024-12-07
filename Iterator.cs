using System.Collections;

namespace RRPS03
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current { get; }

        public abstract bool MoveNext();

        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection collection;

        private int position = -1;

        public object Current { get => this.collection.getItems()[position]; }

        public AlphabeticalOrderIterator(WordsCollection collection)
        {
            this.collection = collection;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this.position;

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this.position = 0;
        }
    }
    class WordsCollection : IteratorAggregate
    {
        List<string> collection = new List<string>();

        public List<string> getItems()
        {
            return collection;
        }

        public void AddItem(string item)
        {
            this.collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this);
        }
    }
}
