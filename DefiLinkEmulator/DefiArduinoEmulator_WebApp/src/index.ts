import "./css/main.css";
import * as signalR from "@microsoft/signalr";
import * as $ from 'jquery';
import {DefiCOMEmulatorStatus} from './model/DefiCOMEmulatorStatus';

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub")
    .build();

window.onload = function()
{
    $.getJSON('DefiEmulator/EmulatorStatus/', null, (emuStatus : DefiCOMEmulatorStatus) =>
    {
        setEmustatus(emuStatus);
    });
};

function setEmustatus(emuStatus : DefiCOMEmulatorStatus)
{
    $('#boostLabel').text("100");

    $('#btnStart').prop('disabled', !emuStatus.isRunning);
    $('#comportNameInput').prop('value', emuStatus.comPortName);

    $('#boostSlider').prop('value', emuStatus.defiCOMParameter["Manifold_Absolute_Pressure"]);
    $('#boostLabel').text(emuStatus.defiCOMParameter["Manifold_Absolute_Pressure"]);
    
    $('#rpmSlider').prop('value', emuStatus.defiCOMParameter["Engine_Speed"]);
    $('#rpmLabel').text(emuStatus.defiCOMParameter["Engine_Speed"]);
    
    $('#oilpresSlider').prop('value', emuStatus.defiCOMParameter["Oil_Pressure"]);
    $('#oilpresLabel').text(emuStatus.defiCOMParameter["Oil_Pressure"]);
    
    $('#fuelpresSlider').prop('value', emuStatus.defiCOMParameter["Fuel_Rail_Pressure"]);
    $('#fuelpresLabel').text(emuStatus.defiCOMParameter["Fuel_Rail_Pressure"]);
    
    $('#exttempSlider').prop('value', emuStatus.defiCOMParameter["Exhaust_Gas_Temperature"]);
    $('#exttempLabel').text(emuStatus.defiCOMParameter["Exhaust_Gas_Temperature"]);
    
    $('#oiltempSlider').prop('value', emuStatus.defiCOMParameter["Oil_Temperature"]);
    $('#oiltempLabel').text(emuStatus.defiCOMParameter["Oil_Temperature"]);
    
    $('#watertempSlider').prop('value', emuStatus.defiCOMParameter["Coolant_Temperature"]);
    $('#watertempLabel').text(emuStatus.defiCOMParameter["Coolant_Temperature"]);
    
}

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