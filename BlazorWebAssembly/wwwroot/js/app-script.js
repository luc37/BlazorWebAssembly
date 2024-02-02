function appGetElementWidthById(id) {
    var element = document.getElementById(id);
    console.log(element.getBoundingClientRect().width);

    if (element)
        return parseInt(element.getBoundingClientRect().width);
    else
        return 0;
}

function appGetElementHeightById(id) {
    var element = document.getElementById(id);
    console.log(element.getBoundingClientRect().height);

    if (element)
        return parseInt(element.getBoundingClientRect().height);
    else
        return 0;
}