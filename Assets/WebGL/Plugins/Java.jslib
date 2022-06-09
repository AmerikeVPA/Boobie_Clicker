mergeInto(LibraryManager.library, {

  SetUser: function (gender, user, money, images) {
    console.log("called NU");
        var xmlHttp = new XMLHttpRequest();
        var theUrl = "ClickerInsert.php?g=" + UTF8ToString(gender) + "&u=" + UTF8ToString(user) + "&m=" + money + "&i=" + images;
        xmlHttp.open( "GET", theUrl, false ); // false for synchronous request
        xmlHttp.send( null );
        var returnStr = xmlHttp.responseText;
        console.log("res " + returnStr);
        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    }
  UpdateUser: function (user, money, images) {
    console.log("called UU");
        var xmlHttp = new XMLHttpRequest();
        var theUrl = "ClickerUpdate.php?u=" + UTF8ToString(user) + "&m=" + money + "&i=" + images;
        xmlHttp.open( "GET", theUrl, false ); // false for synchronous request
        xmlHttp.send( null );
        var returnStr = xmlHttp.responseText;
        console.log("res " + returnStr);
        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;
    }
});