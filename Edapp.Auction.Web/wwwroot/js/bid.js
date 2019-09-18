(function () {
    const consoleId = $('#consoleId').val();

    const bidInput = document.getElementById('bid-amount');
    const highestBidInput = $('#highestBid');

    (function () {
        let connection =
            new signalR.HubConnectionBuilder()
                .withUrl('/bidHub')
                .build();

        connection.start()
            .then(function () {
                connection.invoke('Setup', consoleId);
            })
            .catch(function (err) {
                return console.error(err.toString());
            });

        connection.on('ReceivedMessage',
            function (bidAmount, userId) {

                $('#itemPrice').text(`£${bidAmount}`);
            });
        
        document.getElementById('button-bid').addEventListener('click', function () {
            let bidAmount = bidInput.value;
            let bidMinAttribute = bidInput.min;
            let parsedBidInput = parseFloat(highestBidInput.val());

            let bidAmountId = '#bid-amount';
            if (!bidAmount) {
                $(bidAmountId).notify('Please enter some value in order to bid');
                return;
            }
            if (parsedBidInput === 0 && bidAmount < bidMinAttribute) {
                $(bidAmountId).notify(`Minimum bid amount ${bidMinAttribute}`);
                return;
            }
            if (bidMinAttribute > bidAmount || bidAmount < parsedBidInput) {
                $(bidAmountId).notify('You cannot bid lower amount than the current highest bid');
                return;
            }

            connection.invoke('CreateBidAsync', bidAmount, consoleId);
        });
    })();
})();