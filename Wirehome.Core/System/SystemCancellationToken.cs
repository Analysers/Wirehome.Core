﻿using System.Threading;

namespace Wirehome.Core.System
{
    public class SystemCancellationToken
    {
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        public CancellationToken Token => _cancellationTokenSource.Token;

        public void Cancel()
        {
            _cancellationTokenSource?.Cancel(false);
        }
    }
}
