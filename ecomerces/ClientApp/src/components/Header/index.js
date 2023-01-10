import {Link} from "react-router-dom";
import {AiOutlineSearch} from "react-icons/ai";
import {BsCart3} from "react-icons/bs";
import {useEffect, useState} from "react";

const Header = () => {
    const [userLogin, setUserLogin] = useState(null);
    useEffect(() => {
        setUserLogin(localStorage.getItem('UserName'));
    }, [])
    return (
        <>
            <div className={'w-full bg-[#F7F7F7]'}>
                <div className="container mx-auto">
                    <ul className={'flex justify-between items-center py-1'}>
                        <li>
                            <Link to={''}
                                  className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>tiếp
                                kiệm hơn với người dùng</Link>
                        </li>
                        <li>
                            <Link to={''}
                                  className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>bán
                                hàng cùng lazada</Link>
                        </li>
                        <li>
                            <Link to={''}
                                  className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>chăm
                                sóc khách hàng</Link>
                        </li>
                        <li>
                            <Link to={''}
                                  className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>kiểm
                                tra đơn hàng</Link>
                        </li>
                        <li>
                            {
                                userLogin ? (
                                    <div className={'text-[#0f1568] text-[12px] font-bold no-underline uppercase'}>
                                        {userLogin}
                                    </div>
                                ) : (
                                    <Link to={''}
                                          className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>đăng
                                        nhập</Link>
                                )
                            }
                        </li>
                        {
                            userLogin ? (
                                <></>
                            ) : (
                                <li>
                                    <Link to={''}
                                          className={'text-[#0f1568] text-[12px] no-underline uppercase hover:text-[#f36d00] transition'}>đăng
                                        ký</Link>
                                </li>
                            )
                        }
                    </ul>
                </div>
            </div>
            <div className="main-header">
                <div className="container mx-auto flex justify-between">
                    <Link to={'/'} className="logo w-[127px] h-[40px]">
                        <img src="https://laz-img-cdn.alicdn.com/images/ims-web/TB1T7K2d8Cw3KVjSZFuXXcAOpXa.png"
                             alt=""/>
                    </Link>
                    <div className="input-search flex items-center">
                        <input type="text" className={'bg-[#EFF0F5] px-4 py-2 w-[600px] outline-none'}
                               placeholder={'Tìm kiếm trên lazada'}/>
                        <button
                            className={'bg-[#F57224] h-[40px] w-[40px] flex items-center justify-center text-white'}>
                            <AiOutlineSearch/>
                        </button>
                    </div>
                    <div className={'flex items-center gap-10'}>
                        <Link to={'/cart'} className={'text-xl text-[#0f1568] relative'}>
                            <BsCart3/>
                            <div className={'w-[18px] h-[18px] bg-red-500 absolute -top-2 -right-3 rounded-full text-[12px] text-white flex items-center justify-center'}>
                                <span>0</span>
                            </div>
                        </Link>
                        <img src="https://icms-image.slatic.net/images/ims-web/519f67f2-ad99-4680-b925-2ceb4a3dabea.png"
                             alt="" className={'w-[188px]'}/>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Header