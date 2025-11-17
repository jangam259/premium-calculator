import {useState,useEffect} from 'react';import {calculatePremium} from '../api/premiumApi';
export default function PremiumForm(){
 const [f,setF]=useState({name:'',age:'',dob:'',occupation:'',sumInsured:''});
 const [p,setP]=useState(null);
 const occ=['Cleaner','Doctor'];
 useEffect(()=>{if(Object.values(f).every(x=>x)) calc();},[f.occupation]);
 const ch=e=>setF({...f,[e.target.name]:e.target.value});
 const calc=async()=>setP(await calculatePremium({name:f.name,age:+f.age,dateOfBirth:f.dob+'-01',occupation:f.occupation,sumInsured:+f.sumInsured}));
 return(<div><input name='name' onChange={ch}/><input name='age'onChange={ch}/><input type='month'name='dob'onChange={ch}/><select name='occupation'onChange={ch}><option></option>{occ.map(o=><option key={o}>{o}</option>)}</select><input name='sumInsured'onChange={ch}/>{p&&<h3>{p}</h3>}</div>);
}