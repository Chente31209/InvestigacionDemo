import axios from "axios";

 
    
const ENDPOINT_PATH = "http://localhost:27585/";

export default {
    getCfdi(){
        axios.get(ENDPOINT_PATH+'cfdi', {
            "Access-Control-Allow-Origin": "*"
          }).then(x => {
            console.log(x)
        });
    }
}