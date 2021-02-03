var users = [{name: "Michael", age:37}, {name: "John", age:30}, {name: "David", age:27}];

// print/log John's age
console.log(users[users.map(obj => obj.name).indexOf("John")].age);

// print/log the name of the first object
console.log(users[0].name);

// print/log the name and age of each user using a for loop
for(var index in users){
    console.log(users[index].name + " - " + users[index].age);
}