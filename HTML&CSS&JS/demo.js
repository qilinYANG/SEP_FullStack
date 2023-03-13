let Salary = {John:160,Ann:160,Pete:130}

let total = 0

for(let emp in Salary){
    total += Salary[emp];
}
// console.log(total)

function multiplyNumeric(obj){

    
    for(let key in obj){
        if(typeof obj[key] === "number"){
            obj[key] *= 2;
        }

    }
}

let menu = {
    width: 200,
    height: 300,
    title: "My menu"
}
multiplyNumeric(menu)
// console.log(menu)

function checkEmail(email){
    let idx1 = -1,idx2 = -1;

    idx1 = email.indexOf("@")
    idx2 = email.indexOf(".")

    if(idx1 < 0 || idx2 < 0 || idx2-idx1 < 1){
        return false;
    }

    return true;
}

function truncate(str,maxLength){
    if(str.length <= maxLength){
        return str;
    }

    return str.substring(0,maxLength)+"...";
}

// console.log(truncate("What I'd like to tell on this topic is:", 20));

const strArray = ["James","Brennie"]
strArray.push("Robert")
console.log(strArray)
const middle = Math.floor(strArray.length/2);
strArray[middle] = "Calvin"
console.log(strArray)

strArray.shift();
console.log(strArray)
strArray.push("Rose")
strArray.push("Regal")
console.log(strArray)