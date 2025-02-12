console.log("je moeder");


class dampice {
    constructor(color) {
        this.color = color;
        this.isKing = false;
    }

    setToKing() {
        this.isKing = true;
    }
}

let dam = new dampice("wite");

console.log(dam.isKing);
dam.setToKing();
console.log(dam.isKing);

let dambord =
    [
        [new dampice("wite"), null, new dampice("wite"), null],
        [null, null, null, null],
        [new dampice("black"), null, new dampice("black"), null]
    ];
function doe a move() {

}
function print() {
    for (let i = 0; i < dambord.length; i++) {
        let string = "|";
        for (let j = 0; j < dambord[i].length; j++) {
            if (dambord[i][j] != null) {
                string = string + dambord[i][j].color + "|";
            } else {
                string += " |"
            }
            
        }
        console.log("-------------------------")
        console.log(string);
    }
    console.log("-------------------------")
}
if (dambord[0][1] != null) {
    console.log(dambord[0][1].isKing)
}

const para = document.createElement("p");
para.innerHTML = "aaaa"

// Append to another element:
document.getElementById("myDIV").appendChild(para);
