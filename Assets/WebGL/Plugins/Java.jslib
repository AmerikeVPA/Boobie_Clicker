mergeInto(LibraryManager.library, {

  CheckGender: function (gender) {
    return UTF8ToString(gender);
  }
  EnterUser: function (user) {
    return UTF8ToString(user);
  }
  SaveMoney: function (money) {
    return money;
  }
  SvaeImage: function (images) {
    return images;
  }
  PhPTest: function (str) {
    console.log("called func");
        var xmlHttp = new XMLHttpRequest();
        var theUrl = "ClickerPHP.php?q=" + UTF8ToString(str);
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