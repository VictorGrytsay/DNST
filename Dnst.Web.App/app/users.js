(function () {

    var xhr = new XMLHttpRequest();

    xhr.open('GET', 'users.ashx', true)

    xhr.onloadend = function (response) {
        var json = response.currentTarget.response;
        var users = JSON.parse(json);

        var bodyElement = document.getElementById('tblUsers');

        for (var i = 0; i < users.length; i++) {

            var user = users[i];

            var row = document.createElement('tr');

            var nameCell = document.createElement('td');
            nameCell.innerText = user.Name;

            var emailCell = document.createElement('td');
            emailCell.innerText = user.Email;

            var dateCell = document.createElement('td');
            dateCell.innerText = user.DateCreation;

            row.appendChild(nameCell);
            row.appendChild(emailCell);
            row.appendChild(dateCell);
            bodyElement.appendChild(row);
        }
    };

    xhr.send();

})();