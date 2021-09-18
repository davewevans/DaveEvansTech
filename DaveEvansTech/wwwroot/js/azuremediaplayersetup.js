export function init(id, width, height, src, type, controls, autoplay) {
    
    let myOptions = {
        'nativeControlsForTouch': false,
        controls: controls,
        autoplay: autoplay,
        width: width,
        height: height,
    }
    let myPlayer = amp(id, myOptions);
    myPlayer.src([
        {
            'src': src,
            'type': type
        }
    ]);  
}
