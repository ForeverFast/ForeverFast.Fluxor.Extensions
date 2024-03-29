﻿namespace Fluxor.Extensions
{
    public class Selector<TResult> : ISelector<TResult>
    {
        private Func<IStore, TResult> _projectorFunc;

        public Selector(Func<IStore, TResult> projectorFunc)
        {
            _projectorFunc = projectorFunc;
        }

        public TResult Select(IStore state)
            => _projectorFunc(state);
    }
}