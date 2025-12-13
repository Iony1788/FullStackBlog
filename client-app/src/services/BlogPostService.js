import axios from "axios";

const API_URL = "https://localhost:7151/api/BlogPost";

const getAllBlogPosts = () => {
    return axios.get(`${API_URL}/blogposts`);
};

const getBlogPostById = (id) => {
    return axios.get(`${API_URL}/${id}`);
};

const editBlogPost = (id, data) => {
    return axios.put(`${API_URL}/editBlogPost/${id}`, data);
};

const addBlogPost = (data) => {
    return axios.post(`${API_URL}/addBlogPost`, data);
};

const deleteBlogPost = (id) => {
    return axios.delete(`${API_URL}/delete/${id}`);
}

const paginateBlogPosts = (page, pageSize) => {
    return axios.get(`${API_URL}/paginate?page=${page}&pageSize=${pageSize}`);
};

export default {
    getAllBlogPosts,
    getBlogPostById,
    editBlogPost,
    addBlogPost,
    deleteBlogPost,
    paginateBlogPosts,
};
