import User from "./components/user"
import userEdit from "./components/userEdit"
import apiActions from "./api/apiActions"

export default () =>{
    displayUser()
}

function displayUser(){
    const userBTN = document.querySelector("#userButton");
    userBTN.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44306/api/users", users =>{
            document.querySelector("#app").innerHTML = User(users);
        })
    })

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("userName")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.getRequest(`https://localhost:44306/api/users/${userid}`, users =>{
                document.querySelector("#app").innerHTML = User(users);
            })
        }
    })

    app.addEventListener("click", function(){
        const addUser = event.target.parentElement.querySelector("add-user_name").value;
        const addEmail = event.target.parentElement.querySelector("add-user_email").value;
        const addPhone = event.target.parentElement.querySelector("add-user_phone").value;

        apiActions.postRequest("https://localhost:44306/api/users",
        {
            name: addUser,
            email: addEmail,
            phone: addPhone
        },
        users => {
            document.querySelector("#app").innerHTML = User(users)
        })
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-user")){
            const userid = event.target.parentElement.querySelector(".user_id").value;
            apiActions.deleteRequest(`https://localhost:44306/api/users/${userid}`,
            users => {
                app.innerHTML = User(users);
            })
        }
    })
}