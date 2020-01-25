import "./css/main.css";
import * as signalR from "@microsoft/signalr";
import * as $ from 'jquery';
import {DefiCOMEmulatorStatus} from './model/DefiCOMEmulatorStatus';

const startButton : HTMLButtonElement = document.querySelector("#btnStart");
const comPortInput : HTMLInputElement = document.querySelector("#comportNameInput");
const boostSlider : HTMLInputElement = document.querySelector("#boostSlider");
const boostLabel : HTMLLabelElement = document.querySelector("#boostLabel"); 

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

$(document).ready( () => {
    const emuStatus = $.getJSON('./DefiEmulator/EmulatorStatus');
    console.log(emuStatus.responseJSON);
});

/*
const divMessages: HTMLDivElement = document.querySelector("#divMessages");
const tbMessage: HTMLInputElement = document.querySelector("#tbMessage");
const btnSend: HTMLButtonElement = document.querySelector("#btnSend");
const username = new Date().getTime();

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

connection.on("messageReceived", (username: string, message: string) => {
    let messageContainer = document.createElement("div");

    messageContainer.innerHTML =
        `<div class="message-author">${username}</div><div>${message}</div>`;

    divMessages.appendChild(messageContainer);
    divMessages.scrollTop = divMessages.scrollHeight;
});

connection.start().catch(err => document.write(err));

tbMessage.addEventListener("keyup", (e: KeyboardEvent) => {
    if (e.keyCode === 13) {
        send();
    }
});

btnSend.addEventListener("click", send);

function send() {
    connection.send("newMessage", username, tbMessage.value)
              .then(() => tbMessage.value = "");
}
*/