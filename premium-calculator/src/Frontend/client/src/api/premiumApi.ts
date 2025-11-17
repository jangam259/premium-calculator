import axios from 'axios';
export const calculatePremium=async(data)=> (await axios.post('http://localhost:5000/api/premium/calculate',data)).data;