import moment from "moment";

export default function Activity(activities) {
    return `
    <section>
    <a href="#popup1"><button class="popupButton">Add A New Action</button></a>
    <div id="popup1" class="overlay">
    <div class="popup">
    <a class="close" href="#">&times;</a>
    <div class="content">
    <input class="add-activity_name" id="input1" type="text" placeholder="Add an Action Name" size="40px">
    <select class="add-activity_categoryId" id="input1" name="Category">
    <option value="1">Marketing</option>
    <option value="2">Payroll</option>
    <option value="3">Accounting/Auditing</option>
    <option value="4">Customer Service</option>
    <option value="5">Budgeting</option>
    <option value="6">Sales</option>
    <option value="7">Operations</option>
    <option value="8">Small Tasks</option>
    </select>
    <input class="add-activity_importance" id="input1" type="text" placeholder="Add an Action Importance 1-10" size="40px">
    <input class="add-activity_urgency" id="input1" type="text" placeholder="Add an Action Urgency 1-10" size="40px">
    <textarea rows="5" cols="37" class="add-activity_description" id="input1" placeholder="Add an Action Description" size="40px"></textarea>
    <input class="add-activity_done" type="hidden">
    <button class='add-activity' id="mainbutton">Add</button>
    </div>
    </div>
    </div>
    </section>
    
    <section class="gridAct">
    ${activities
        .map(activity => {
            var timeCreated = moment(activity.creation + 'Z').format('MMMM Do YYYY, h:mm a');
            
            return `
            <section class="activity">
            
            <h3 class="activity_name">${activity.name}</h3>
            <p class="activity_description">${activity.description}</p>
            <p class="activity_importance">Importance: ${activity.importance}</p>
            <p class="activity_urgency">Urgency: ${activity.urgency}</p>
            <p class="activity_creation">Started: <br>${timeCreated}</p>
            
            <input class="activity_id" type="hidden" value="${activity.id}">
            <input class="activity_categoryId" type="hidden" value="${activity.categoryID}">
            <section class="complete-activity">
            <input class="complete-activity_name" type="hidden" value="${activity.name}">
            <input class="complete-activity_importance" type="hidden" value="${activity.importance}">
                        <input class="complete-activity_urgency" type="hidden" value="${activity.urgency}">
                        <input class="complete-activity_creation" type="hidden" value="${activity.creation}">
                        
                        <input class="complete-activity_categoryId" type="hidden" value="${activity.categoryID}">
                        <input class="complete-activity_description" type="hidden" value="${activity.description}">
                        <input class="complete-activity" type="checkbox">
                        <input class="complete-activity_id" type="hidden" value="${activity.id}">
                        <input class="complete-activity_done" type="hidden" value="${activity.done}">
                        </section>
                        <button class="edit-activity" id="mainbutton">Edit</button>
                        <button class="delete-activity" id="mainbutton">Delete</button>
                        </section>
                        `;
                    })
                    .join("")}
                    </section>
                    `
                    // <p class="activity_category">Department: ${activity.category.name}</p>
}