window.addEventListener('load', mainColorPicker, false);

function mainColorPicker() {
    let galleryLargeImage = document.getElementsByClassName("gallery-large-image");
    let galleryLargeContent = document.getElementsByClassName("gallery-large-content");
    for (let j = 0; j < galleryLargeImage.length; j++) {
        let vibrant = new Vibrant(galleryLargeImage[j]);
        let swatches  = vibrant.swatches();
        let holderColors = [];
        for (let swatch in swatches){
            if (swatches.hasOwnProperty(swatch) && swatches[swatch]){
                console.log(swatch, swatches[swatch].getRgb());
                if (swatch === "DarkVibrant" || swatch === "DarkMuted") {
                    let color = swatches[swatch].getRgb();
                    let oneColor = "rgba(" + color[0] + ", " + color[1] + ", " + color[2] + ", 0.5)";
                    holderColors.push(oneColor);
                }
            }
        }
        galleryLargeContent[j].style.backgroundImage = "linear-gradient(to bottom, " + holderColors[0]  + " 0%, " + holderColors[1] + " 100%)";
    }
}