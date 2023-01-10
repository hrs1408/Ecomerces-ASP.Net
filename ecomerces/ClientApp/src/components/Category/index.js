import {Link} from "react-router-dom";
import {useEffect, useState} from "react";
import axios from "axios";

const Category = () => {
    const [categories, setCategories] = useState([]);
    useEffect(() => {
        const fetchData = async () => {
            const result = await axios(
                'https://localhost:7087/Category/GetAll',
            );
            setCategories(result.data);
        }
        fetchData();
    }, []);
    return (
        <div className={'container mx-auto py-10'}>
            <h4>Danh mục ngành hàng</h4>
            <div className={'grid grid-cols-8 mt-4'}>
                {
                    categories.map(category => (
                        <CategoryItem key={category.id} name={category.name} image={category.image}/>
                    ))
                }
            </div>
        </div>
    )
}

const CategoryItem  = ({image, name}) => {
    return (
        <Link to={''} className={'flex flex-col items-center justify-center gap-2 bg-white h-[150px] no-underline hover:shadow transition border'}>
            <img src={image} alt="" className={'w-[80px] h-[80px]'}/>
            <p className={'text-[14px] text-black'}>{name}</p>
        </Link>
    )
}

export default Category