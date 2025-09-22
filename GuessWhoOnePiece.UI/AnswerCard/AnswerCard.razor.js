/* 
   Copyright (c) 2025 All Rights Reserved. 
   Author: Gabriel Marquette
*/

export function adjustFontSize() {
    const answerCircles = document.querySelectorAll(".answer-circle");

    answerCircles.forEach((circle) => {
        const text = circle.querySelector(".answer-text");
        if (text) {
            let fontSize = 40;
            text.style.fontSize = `${fontSize}px`;

            while (text.scrollHeight > circle.clientHeight && fontSize > 30) {
                fontSize--;
                text.style.fontSize = `${fontSize}px`;
            }
        }
    });
}