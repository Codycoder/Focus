import apiActions from "../api/apiActions"
import ActivityRank from "./activityRank"
import ActivityDetails from "./activityDetails"

export default () => {
    displayHome()
}

function displayHome(){
    const app = document.querySelector("#app");
    const sign = document.querySelector("#sign");
    const total = document.querySelector("#points");
    const belts = document.querySelector("#belt");
    apiActions.getRequest(`https://localhost:44306/api/activities/suggest`, activities =>{
        app.innerHTML = ActivityRank(activities);
        sign.innerHTML = ``;
        total.innerHTML = ``;
        belts.innerHTML = ``;
    });
    
}