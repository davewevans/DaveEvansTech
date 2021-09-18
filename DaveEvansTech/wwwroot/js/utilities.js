

function focusInput(id) {
    if (document.getElementById(id) !== null){
        document.getElementById(id).focus();
    }
}

function showAlert(message) {
    alert(message);
}

function BlazorFocusElement(element) {
    if (element instanceof HTMLElement) {
        element.focus();
    }
}

function elementInViewport(id) {

    console.log('elementInViewport invoked: ' + id);
    
    let element = document.getElementById(id);
    let bounding = element.getBoundingClientRect();

    if (bounding.top >= 0 && bounding.left >= 0 && bounding.right <= (window.innerWidth || document.documentElement.clientWidth) && bounding.bottom <= (window.innerHeight || document.documentElement.clientHeight)) {

        console.log('Element is in the viewport!');
    } else {

        console.log('Element is NOT in the viewport!');
    }
}

function BlazorScrollToId(id) {
    const element = document.getElementById(id);
    if (element instanceof HTMLElement) {
        element.scrollIntoView({
            behavior: "smooth",
            block: "start",
            inline: "nearest"
        });
    }
}
